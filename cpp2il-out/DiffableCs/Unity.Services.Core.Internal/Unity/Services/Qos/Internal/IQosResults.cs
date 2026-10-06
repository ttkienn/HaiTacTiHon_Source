namespace Unity.Services.Qos.Internal;

[RequireImplementors]
public interface IQosResults : IServiceComponent
{

	public Task<IList`1<QosResult>> GetSortedQosResultsAsync(string service, IList<String> regions) { }

}

