namespace UnityEngine.Rendering;

public abstract class RenderPipelineAsset : ScriptableObject
{

	public override Shader autodeskInteractiveMaskedShader
	{
		 get { } //Length: 3
	}

	public override Shader autodeskInteractiveShader
	{
		 get { } //Length: 3
	}

	public override Shader autodeskInteractiveTransparentShader
	{
		 get { } //Length: 3
	}

	public override Material default2DMaskMaterial
	{
		 get { } //Length: 3
	}

	public override Material default2DMaterial
	{
		 get { } //Length: 3
	}

	public override Material defaultLineMaterial
	{
		 get { } //Length: 3
	}

	public override Material defaultMaterial
	{
		 get { } //Length: 3
	}

	public override Material defaultParticleMaterial
	{
		 get { } //Length: 3
	}

	public override Shader defaultShader
	{
		 get { } //Length: 3
	}

	public override Shader defaultSpeedTree7Shader
	{
		 get { } //Length: 3
	}

	public override Shader defaultSpeedTree8Shader
	{
		 get { } //Length: 3
	}

	public override Material defaultTerrainMaterial
	{
		 get { } //Length: 3
	}

	public override Material defaultUIETC1SupportedMaterial
	{
		 get { } //Length: 3
	}

	public override Material defaultUIMaterial
	{
		 get { } //Length: 3
	}

	public override Material defaultUIOverdrawMaterial
	{
		 get { } //Length: 3
	}

	public override String[] prefixedRenderingLayerMaskNames
	{
		 get { } //Length: 3
	}

	public override String[] renderingLayerMaskNames
	{
		 get { } //Length: 3
	}

	public override string renderPipelineShaderTag
	{
		 get { } //Length: 113
	}

	public override Shader terrainDetailGrassBillboardShader
	{
		 get { } //Length: 3
	}

	public override Shader terrainDetailGrassShader
	{
		 get { } //Length: 3
	}

	public override Shader terrainDetailLitShader
	{
		 get { } //Length: 3
	}

	protected RenderPipelineAsset() { }

	protected abstract RenderPipeline CreatePipeline() { }

	public override Shader get_autodeskInteractiveMaskedShader() { }

	public override Shader get_autodeskInteractiveShader() { }

	public override Shader get_autodeskInteractiveTransparentShader() { }

	public override Material get_default2DMaskMaterial() { }

	public override Material get_default2DMaterial() { }

	public override Material get_defaultLineMaterial() { }

	public override Material get_defaultMaterial() { }

	public override Material get_defaultParticleMaterial() { }

	public override Shader get_defaultShader() { }

	public override Shader get_defaultSpeedTree7Shader() { }

	public override Shader get_defaultSpeedTree8Shader() { }

	public override Material get_defaultTerrainMaterial() { }

	public override Material get_defaultUIETC1SupportedMaterial() { }

	public override Material get_defaultUIMaterial() { }

	public override Material get_defaultUIOverdrawMaterial() { }

	public override String[] get_prefixedRenderingLayerMaskNames() { }

	public override String[] get_renderingLayerMaskNames() { }

	public override string get_renderPipelineShaderTag() { }

	public override Shader get_terrainDetailGrassBillboardShader() { }

	public override Shader get_terrainDetailGrassShader() { }

	public override Shader get_terrainDetailLitShader() { }

	internal RenderPipeline InternalCreatePipeline() { }

	protected override void OnDisable() { }

	protected override void OnValidate() { }

}

