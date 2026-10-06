namespace System.Threading.Tasks;

internal enum CausalityRelation
{
	AssignDelegate = 0,
	Join = 1,
	Choice = 2,
	Cancel = 3,
	Error = 4,
}

