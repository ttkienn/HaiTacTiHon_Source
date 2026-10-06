namespace System.Xml.Schema;

internal class Datatype_nonPositiveInteger : Datatype_integer
{
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x0

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 78
	}

	internal virtual bool HasValueFacets
	{
		internal get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	private static Datatype_nonPositiveInteger() { }

	public Datatype_nonPositiveInteger() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual bool get_HasValueFacets() { }

	public virtual XmlTypeCode get_TypeCode() { }

}

