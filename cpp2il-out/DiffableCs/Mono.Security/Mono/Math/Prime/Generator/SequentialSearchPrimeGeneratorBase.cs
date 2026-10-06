namespace Mono.Math.Prime.Generator;

public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
{

	public SequentialSearchPrimeGeneratorBase() { }

	public virtual BigInteger GenerateNewPrime(int bits) { }

	public override BigInteger GenerateNewPrime(int bits, object context) { }

	protected override BigInteger GenerateSearchBase(int bits, object context) { }

	protected override bool IsPrimeAcceptable(BigInteger bi, object context) { }

}

