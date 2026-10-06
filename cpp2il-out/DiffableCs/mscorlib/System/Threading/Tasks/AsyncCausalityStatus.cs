namespace System.Threading.Tasks;

[FriendAccessAllowed]
internal enum AsyncCausalityStatus
{
	Started = 0,
	Completed = 1,
	Canceled = 2,
	Error = 3,
}

