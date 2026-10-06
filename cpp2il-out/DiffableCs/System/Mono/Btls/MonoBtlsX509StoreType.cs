namespace Mono.Btls;

internal enum MonoBtlsX509StoreType
{
	Custom = 0,
	MachineTrustedRoots = 1,
	MachineIntermediateCA = 2,
	MachineUntrusted = 3,
	UserTrustedRoots = 4,
	UserIntermediateCA = 5,
	UserUntrusted = 6,
}

