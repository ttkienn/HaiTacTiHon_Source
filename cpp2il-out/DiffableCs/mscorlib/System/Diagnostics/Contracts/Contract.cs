namespace System.Diagnostics.Contracts;

public static class Contract
{

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	public static bool ForAll(IEnumerable<T> collection, Predicate<T> predicate) { }

}

