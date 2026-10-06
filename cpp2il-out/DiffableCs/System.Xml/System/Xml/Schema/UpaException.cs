namespace System.Xml.Schema;

internal class UpaException : Exception
{
	private object particle1; //Field offset: 0x90
	private object particle2; //Field offset: 0x98

	public object Particle1
	{
		 get { } //Length: 8
	}

	public object Particle2
	{
		 get { } //Length: 8
	}

	public UpaException(object particle1, object particle2) { }

	public object get_Particle1() { }

	public object get_Particle2() { }

}

