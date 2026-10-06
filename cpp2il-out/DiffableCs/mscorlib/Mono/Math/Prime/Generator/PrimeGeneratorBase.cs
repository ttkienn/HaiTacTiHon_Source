namespace Mono.Math.Prime.Generator;

internal abstract class PrimeGeneratorBase
{

	public override ConfidenceFactor Confidence
	{
		 get { } //Length: 6
	}

	public override PrimalityTest PrimalityTest
	{
		 get { } //Length: 313
	}

	public override int TrialDivisionBounds
	{
		 get { } //Length: 6
	}

	protected PrimeGeneratorBase() { }

	public abstract BigInteger GenerateNewPrime(int bits) { }

	public override ConfidenceFactor get_Confidence() { }

	public override PrimalityTest get_PrimalityTest() { }

	public override int get_TrialDivisionBounds() { }

}

