namespace System;

[ClassInterface(ClassInterfaceType::AutoDual (2))]
[ComVisible(True)]
public class object
{

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public Object() { }

	public override bool Equals(object obj) { }

	public static bool Equals(object objA, object objB) { }

	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	private void FieldSetter(string typeName, string fieldName, object val) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	protected override void Finalize() { }

	public override int GetHashCode() { }

	public Type GetType() { }

	internal static int InternalGetHashCode(object o) { }

	protected object MemberwiseClone() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static bool ReferenceEquals(object objA, object objB) { }

	public override string ToString() { }

}

