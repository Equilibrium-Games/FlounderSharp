// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FlounderSharp
{
    public unsafe partial class LoadedValue : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 80)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr m_parent;

            [FieldOffset(8)]
            internal global::System.IntPtr m_children;

            [FieldOffset(16)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_name;

            [FieldOffset(48)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_value;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0LoadedValue@fl@@QEAA@PEAV01@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@1@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::System.IntPtr parent, global::System.IntPtr name, global::System.IntPtr value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0LoadedValue@fl@@QEAA@AEBV01@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??1LoadedValue@fl@@QEAA@XZ")]
            internal static extern void dtor(global::System.IntPtr instance, int delete);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetChild@LoadedValue@fl@@QEAAPEAV12@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@AEB_N@Z")]
            internal static extern global::System.IntPtr GetChild(global::System.IntPtr instance, global::System.IntPtr name, bool* addIfNull);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetChild@LoadedValue@fl@@QEAAPEAV12@AEBIAEB_N@Z")]
            internal static extern global::System.IntPtr GetChild(global::System.IntPtr instance, uint* index, bool* addIfNull);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetChildWithAttribute@LoadedValue@fl@@QEAAPEAV12@AEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@00@Z")]
            internal static extern global::System.IntPtr GetChildWithAttribute(global::System.IntPtr instance, global::System.IntPtr childName, global::System.IntPtr attribute, global::System.IntPtr value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetRaw@LoadedValue@fl@@QEBA?AV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@XZ")]
            internal static extern void GetRaw(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SetRaw@LoadedValue@fl@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z")]
            internal static extern void SetRaw(global::System.IntPtr instance, global::System.IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?GetString@LoadedValue@fl@@QEAA?AV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@XZ")]
            internal static extern void GetString(global::System.IntPtr instance, global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?SetString@LoadedValue@fl@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z")]
            internal static extern void SetString(global::System.IntPtr instance, global::System.IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Flounder", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="?ChildrenCount@LoadedValue@fl@@QEBAIXZ")]
            internal static extern uint ChildrenCount(global::System.IntPtr instance);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.LoadedValue> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::FlounderSharp.LoadedValue>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::FlounderSharp.LoadedValue __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::FlounderSharp.LoadedValue(native.ToPointer(), skipVTables);
        }

        internal static global::FlounderSharp.LoadedValue __CreateInstance(global::FlounderSharp.LoadedValue.__Internal native, bool skipVTables = false)
        {
            return new global::FlounderSharp.LoadedValue(native, skipVTables);
        }

        private static void* __CopyValue(global::FlounderSharp.LoadedValue.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.LoadedValue.__Internal));
            global::FlounderSharp.LoadedValue.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private LoadedValue(global::FlounderSharp.LoadedValue.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LoadedValue(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public LoadedValue(global::FlounderSharp.LoadedValue parent, string name, string value)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.LoadedValue.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var __arg0 = ReferenceEquals(parent, null) ? global::System.IntPtr.Zero : parent.__Instance;
            var __allocator1 = new global::Std.Allocator<char>();
            var __basicString1 = global::Std.BasicStringExtensions.BasicString(name, __allocator1);
            var __arg1 = __basicString1.__Instance;
            var __allocator2 = new global::Std.Allocator<char>();
            var __basicString2 = global::Std.BasicStringExtensions.BasicString(value, __allocator2);
            var __arg2 = __basicString2.__Instance;
            __Internal.ctor((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2);
            __basicString1.Dispose(false);
            __allocator1.Dispose();
            __basicString2.Dispose(false);
            __allocator2.Dispose();
        }

        public LoadedValue(global::FlounderSharp.LoadedValue _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::FlounderSharp.LoadedValue.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
        }

        ~LoadedValue()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::FlounderSharp.LoadedValue __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (disposing)
                __Internal.dtor((__Instance + __PointerAdjustment), 0);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::FlounderSharp.LoadedValue GetChild(string name, ref bool addIfNull)
        {
            var __allocator0 = new global::Std.Allocator<char>();
            var __basicString0 = global::Std.BasicStringExtensions.BasicString(name, __allocator0);
            var __arg0 = __basicString0.__Instance;
            fixed (bool* __refParamPtr1 = &addIfNull)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.GetChild((__Instance + __PointerAdjustment), __arg0, __arg1);
                __basicString0.Dispose(false);
                __allocator0.Dispose();
                global::FlounderSharp.LoadedValue __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.LoadedValue.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::FlounderSharp.LoadedValue) global::FlounderSharp.LoadedValue.NativeToManagedMap[__ret];
                else __result0 = global::FlounderSharp.LoadedValue.__CreateInstance(__ret);
                return __result0;
            }
        }

        public global::FlounderSharp.LoadedValue GetChild(ref uint index, ref bool addIfNull)
        {
            fixed (uint* __refParamPtr0 = &index)
            {
                var __arg0 = __refParamPtr0;
                fixed (bool* __refParamPtr1 = &addIfNull)
                {
                    var __arg1 = __refParamPtr1;
                    var __ret = __Internal.GetChild((__Instance + __PointerAdjustment), __arg0, __arg1);
                    global::FlounderSharp.LoadedValue __result0;
                    if (__ret == IntPtr.Zero) __result0 = null;
                    else if (global::FlounderSharp.LoadedValue.NativeToManagedMap.ContainsKey(__ret))
                        __result0 = (global::FlounderSharp.LoadedValue) global::FlounderSharp.LoadedValue.NativeToManagedMap[__ret];
                    else __result0 = global::FlounderSharp.LoadedValue.__CreateInstance(__ret);
                    return __result0;
                }
            }
        }

        public global::FlounderSharp.LoadedValue GetChildWithAttribute(string childName, string attribute, string value)
        {
            var __allocator0 = new global::Std.Allocator<char>();
            var __basicString0 = global::Std.BasicStringExtensions.BasicString(childName, __allocator0);
            var __arg0 = __basicString0.__Instance;
            var __allocator1 = new global::Std.Allocator<char>();
            var __basicString1 = global::Std.BasicStringExtensions.BasicString(attribute, __allocator1);
            var __arg1 = __basicString1.__Instance;
            var __allocator2 = new global::Std.Allocator<char>();
            var __basicString2 = global::Std.BasicStringExtensions.BasicString(value, __allocator2);
            var __arg2 = __basicString2.__Instance;
            var __ret = __Internal.GetChildWithAttribute((__Instance + __PointerAdjustment), __arg0, __arg1, __arg2);
            __basicString0.Dispose(false);
            __allocator0.Dispose();
            __basicString1.Dispose(false);
            __allocator1.Dispose();
            __basicString2.Dispose(false);
            __allocator2.Dispose();
            global::FlounderSharp.LoadedValue __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::FlounderSharp.LoadedValue.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::FlounderSharp.LoadedValue) global::FlounderSharp.LoadedValue.NativeToManagedMap[__ret];
            else __result0 = global::FlounderSharp.LoadedValue.__CreateInstance(__ret);
            return __result0;
        }

        public global::FlounderSharp.LoadedValue MParent
        {
            get
            {
                global::FlounderSharp.LoadedValue __result0;
                if (((global::FlounderSharp.LoadedValue.__Internal*) __Instance)->m_parent == IntPtr.Zero) __result0 = null;
                else if (global::FlounderSharp.LoadedValue.NativeToManagedMap.ContainsKey(((global::FlounderSharp.LoadedValue.__Internal*) __Instance)->m_parent))
                    __result0 = (global::FlounderSharp.LoadedValue) global::FlounderSharp.LoadedValue.NativeToManagedMap[((global::FlounderSharp.LoadedValue.__Internal*) __Instance)->m_parent];
                else __result0 = global::FlounderSharp.LoadedValue.__CreateInstance(((global::FlounderSharp.LoadedValue.__Internal*) __Instance)->m_parent);
                return __result0;
            }

            set
            {
                ((global::FlounderSharp.LoadedValue.__Internal*)__Instance)->m_parent = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public string MName
        {
            get
            {
                var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(new global::System.IntPtr(&((global::FlounderSharp.LoadedValue.__Internal*) __Instance)->m_name));
                var __stringRet = global::Std.BasicStringExtensions.CStr(__basicStringRet);
                __basicStringRet.Dispose(false);
                return __stringRet;
            }

            set
            {
                var __allocator0 = new global::Std.Allocator<char>();
                var __basicString0 = global::Std.BasicStringExtensions.BasicString(value, __allocator0);
                ((global::FlounderSharp.LoadedValue.__Internal*)__Instance)->m_name = *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) __basicString0.__Instance;
            }
        }

        public string MValue
        {
            get
            {
                var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(new global::System.IntPtr(&((global::FlounderSharp.LoadedValue.__Internal*) __Instance)->m_value));
                var __stringRet = global::Std.BasicStringExtensions.CStr(__basicStringRet);
                __basicStringRet.Dispose(false);
                return __stringRet;
            }

            set
            {
                var __allocator0 = new global::Std.Allocator<char>();
                var __basicString0 = global::Std.BasicStringExtensions.BasicString(value, __allocator0);
                ((global::FlounderSharp.LoadedValue.__Internal*)__Instance)->m_value = *(global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C*) __basicString0.__Instance;
            }
        }

        public string Raw
        {
            get
            {
                var __ret = new global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C();
                __Internal.GetRaw((__Instance + __PointerAdjustment), new IntPtr(&__ret));
                var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(__ret);
                var __stringRet = global::Std.BasicStringExtensions.CStr(__basicStringRet);
                __basicStringRet.Dispose(false);
                return __stringRet;
            }

            set
            {
                var __allocator0 = new global::Std.Allocator<char>();
                var __basicString0 = global::Std.BasicStringExtensions.BasicString(value, __allocator0);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetRaw((__Instance + __PointerAdjustment), __arg0);
                __basicString0.Dispose(false);
                __allocator0.Dispose();
            }
        }

        public string String
        {
            get
            {
                var __ret = new global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C();
                __Internal.GetString((__Instance + __PointerAdjustment), new IntPtr(&__ret));
                var __basicStringRet = global::Std.BasicString<char, global::Std.CharTraits<char>, global::Std.Allocator<char>>.__CreateInstance(__ret);
                var __stringRet = global::Std.BasicStringExtensions.CStr(__basicStringRet);
                __basicStringRet.Dispose(false);
                return __stringRet;
            }

            set
            {
                var __allocator0 = new global::Std.Allocator<char>();
                var __basicString0 = global::Std.BasicStringExtensions.BasicString(value, __allocator0);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetString((__Instance + __PointerAdjustment), __arg0);
                __basicString0.Dispose(false);
                __allocator0.Dispose();
            }
        }

        public uint ChildrenCount
        {
            get
            {
                var __ret = __Internal.ChildrenCount((__Instance + __PointerAdjustment));
                return __ret;
            }
        }
    }
}

namespace Std
{
    namespace Pair
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public unsafe partial struct __Internal_Ptr
        {
            [FieldOffset(0)]
            internal global::System.IntPtr first;

            [FieldOffset(8)]
            internal global::System.IntPtr second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public unsafe partial struct __Internalc__N_std_S_pair__1I____N_fl_S_FontCharacter
        {
            [FieldOffset(0)]
            internal int first;

            [FieldOffset(8)]
            internal global::System.IntPtr second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 80)]
        public unsafe partial struct __Internalc__N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C___N_fl_S_ConfigKey
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::FlounderSharp.ConfigKey.__Internal second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public unsafe partial struct __Internalc__N_std_S_pair____N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_fl_S_IModule
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::System.IntPtr second;
        }

        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public unsafe partial struct __Internalc__N_std_S_pair__1__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C____N_fl_S_JointTransform
        {
            [FieldOffset(0)]
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C first;

            [FieldOffset(32)]
            internal global::System.IntPtr second;
        }
    }
}