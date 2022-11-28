using UnityEngine;

public class StateMachine<TContext> : MonoBehaviour
	where TContext : class, new()
{
	public IState<TContext> CurrentState { get; protected set; }

	public readonly TContext Context = new();
}
