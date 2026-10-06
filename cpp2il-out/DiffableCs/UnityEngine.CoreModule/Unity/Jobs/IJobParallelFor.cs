namespace Unity.Jobs;

[JobProducerType(typeof(ParallelForJobStruct`1))]
public interface IJobParallelFor
{

	public void Execute(int index) { }

}

