namespace UnityEngine;

[NativeHeader("Runtime/Shaders/Material.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
public class Material : object
{

	public Texture mainTexture
	{
		 get { } //Length: 182
	}

	public Shader shader
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public String[] shaderKeywords
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Material(Shader shader) { }

	[RequiredByNativeCode]
	public Material(Material source) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	public Material(string contents) { }

	public int ComputeCRC() { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithShader")]
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	private static void CreateWithString(Material self) { }

	public void DisableKeyword(string keyword) { }

	public void EnableKeyword(string keyword) { }

	public Texture get_mainTexture() { }

	public Shader get_shader() { }

	public String[] get_shaderKeywords() { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	public float GetFloat(int nameID) { }

	[NativeName("GetFloatFromScript")]
	private float GetFloatImpl(int name) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	private String[] GetShaderKeywords() { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[NativeName("GetTag")]
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public Texture GetTexture(int nameID) { }

	public Texture GetTexture(string name) { }

	[NativeName("GetTextureFromScript")]
	private Texture GetTextureImpl(int name) { }

	public bool HasProperty(string name) { }

	[NativeName("HasPropertyFromScript")]
	public bool HasProperty(int nameID) { }

	public void set_shader(Shader value) { }

	public void set_shaderKeywords(String[] value) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	[NativeName("SetFloatFromScript")]
	private void SetFloatImpl(int name, float value) { }

	[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = True)]
	public bool SetPass(int pass) { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	private void SetShaderKeywords(String[] names) { }

	public void SetTexture(int nameID, Texture value) { }

	[NativeName("SetTextureFromScript")]
	private void SetTextureImpl(int name, Texture value) { }

}

