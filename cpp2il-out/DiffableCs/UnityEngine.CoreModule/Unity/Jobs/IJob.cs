namespace Unity.Jobs;

[JobProducerType(typeof(JobStruct`1))]
public interface IJob
{

	public void Execute() { }

}

