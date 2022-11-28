using UnityEngine;

public abstract class FlyState : State<FlyStateMachine, FlyContext>
{
	public FlyStateMachine Fly => StateMachine;
	public FlyZone Zone => Context.FlyZone;
	public Transform Transform => Context.Transform;
}