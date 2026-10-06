namespace System.Net.NetworkInformation;

public class PhysicalAddress
{
	public static readonly PhysicalAddress None; //Field offset: 0x0
	private Byte[] address; //Field offset: 0x10
	private bool changed; //Field offset: 0x18
	private int hash; //Field offset: 0x1C

	private static PhysicalAddress() { }

	public PhysicalAddress(Byte[] address) { }

	public virtual bool Equals(object comparand) { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

