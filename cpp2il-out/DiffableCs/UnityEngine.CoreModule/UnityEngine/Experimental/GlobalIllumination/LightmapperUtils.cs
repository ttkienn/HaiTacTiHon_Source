namespace UnityEngine.Experimental.GlobalIllumination;

public static class LightmapperUtils
{

	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	public static LightMode Extract(LightmapBakeType baketype) { }

	public static void Extract(Light l, ref DirectionalLight dir) { }

	public static void Extract(Light l, ref PointLight point) { }

	public static void Extract(Light l, ref SpotLight spot) { }

	public static void Extract(Light l, ref RectangleLight rect) { }

	public static void Extract(Light l, ref DiscLight disc) { }

	public static void Extract(Light l, out Cookie cookie) { }

	private static Color ExtractColorTemperature(Light l) { }

	public static LinearColor ExtractIndirect(Light l) { }

	public static float ExtractInnerCone(Light l) { }

}

