namespace Unity.Services.Analytics.Internal;

internal interface IAnalyticsForgetter
{

	public bool DeletionInProgress
	{
		 get { } //Length: 0
	}

	public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback) { }

	public bool get_DeletionInProgress() { }

	public void ResetDataDeletionStatus() { }

}

