namespace UnityEngine;

[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject
{

	protected StateMachineBehaviour() { }

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

}

