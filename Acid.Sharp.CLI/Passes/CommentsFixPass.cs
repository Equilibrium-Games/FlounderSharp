﻿using CppSharp;
using CppSharp.AST;
using CppSharp.Passes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AcidSharp.CLI.Passes
{
    public class PassCommentsFix : TranslationUnitPass
    {
        private readonly Regex _rx = new Regex(@"///(?<text>.*)", RegexOptions.ExplicitCapture | RegexOptions.Compiled);
        
        public override bool VisitDeclaration(Declaration declaration)
        {
            if (AlreadyVisited(declaration))
            {
                return false;
            }

            if (declaration.Comment != null)
            {
                var xDoc = GetOriginalDocumentationDocument(declaration.Comment.Text);

                var xRoot = xDoc?.Root;

                if (xRoot == null)
                {
                    return false;
                }

                declaration.Comment.Kind = CommentKind.BCPLSlash;
                var fullComment = declaration.Comment.FullComment;
                fullComment.Blocks.Clear();

                var summaryPara = new ParagraphComment();
                var summaryElement = xRoot.Element("summary");
                summaryPara.Content.Add(new TextComment { Text = summaryElement == null ? "" : summaryElement.Value.ReplaceLineBreaks("").Trim() });
                fullComment.Blocks.Add(summaryPara);

                var remarksElement = xRoot.Element("remarks");

                if (remarksElement != null)
                {
                    foreach (var remarksLine in remarksElement.Value.Split('\n'))
                    {
                        var remarksPara = new ParagraphComment();
                        remarksPara.Content.Add(new TextComment { Text = remarksLine.ReplaceLineBreaks("").Trim() });
                        fullComment.Blocks.Add(remarksPara);
                    }
                }

                var paramElements = xRoot.Elements("param");

                foreach (var paramElement in paramElements)
                {
                    var paramComment = new ParamCommandComment();
                    var name = paramElement.Attribute("name");
                    paramComment.Arguments.Add(new BlockCommandComment.Argument { Text = name?.Value });
                    paramComment.ParagraphComment = new ParagraphComment();
                    StringBuilder paramTextCommentBuilder = new StringBuilder();

                    foreach (var paramLine in paramElement.Value.Split('\n'))
                    {
                        paramTextCommentBuilder.Append(paramLine.ReplaceLineBreaks("").Trim() + " ");
                    }

                    paramComment.ParagraphComment.Content.Add(new TextComment { Text = paramTextCommentBuilder.ToString() });
                    fullComment.Blocks.Add(paramComment);
                }
            }

            // Fix Enum comments.
            if (declaration is Enumeration enumDecl)
            {
                foreach (var item in enumDecl.Items.Where(i => i.Comment != null))
                {
                    item.Comment.BriefText = item.Comment.BriefText.Replace("<summary>", "").Replace("</summary>", "").Trim();
                }
            }

            return true;
        }

        private XDocument GetOriginalDocumentationDocument(string documentationText)
        {
            var descriptionXmlBuilder = new StringBuilder();
            descriptionXmlBuilder.AppendLine("<description>");

            foreach (Match match in _rx.Matches(documentationText))
            {
                var text = match.Groups["text"].Value;
                descriptionXmlBuilder.Append(text);
            }

            descriptionXmlBuilder.AppendLine("</description>");

            try
            {
                var descriptionXDoc = XDocument.Parse(descriptionXmlBuilder.ToString());
                return descriptionXDoc;
            }
            catch (System.Xml.XmlException exception)
            {
            }

            return null;
        }
    }
}