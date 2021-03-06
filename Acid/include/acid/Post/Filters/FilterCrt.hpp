#pragma once

#include "Maths/Colour.hpp"
#include "Post/IPostFilter.hpp"

namespace acid
{
	class ACID_EXPORT FilterCrt :
		public IPostFilter
	{
	private:
		PushHandler m_pushScene;

		Colour m_screenColour;
		float m_curveAmountX;
		float m_curveAmountY;
		float m_scanLineSize;
		float m_scanIntensity;
	public:
		explicit FilterCrt(const GraphicsStage &graphicsStage, const Colour &screenColour = Colour(0.5f, 1.0f, 0.5f), const float &curveAmountX = 0.1f, const float &curveAmountY = 0.1f, const float &scanLineSize = 1000.0f, const float &scanIntensity = 0.1f);

		void Render(const CommandBuffer &commandBuffer, const Vector4 &clipPlane, const ICamera &camera) override;

		Colour GetScreenColour() const { return m_screenColour; }

		void SetScreenColour(const Colour &screenColour) { m_screenColour = screenColour; }

		float GetCurveAmountX() const { return m_curveAmountX; }

		void SetCurveAmountX(const float &curveAmountX) { m_curveAmountX = curveAmountX; }

		float GetCurveAmountY() const { return m_curveAmountY; }

		void SetCurveAmountY(const float &curveAmountY) { m_curveAmountY = curveAmountY; }

		float GetScanLineSize() const { return m_scanLineSize; }

		void SetScanLineSize(const float &scanLineSize) { m_scanLineSize = scanLineSize; }

		float GetScanIntensity() const { return m_scanIntensity; }

		void SetScanIntensity(const float &scanIntensity) { m_scanIntensity = scanIntensity; }
	};
}
