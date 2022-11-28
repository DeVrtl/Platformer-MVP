using System;

public abstract class State<TStateMachine, TContext> : IState<TContext>
    where TStateMachine : StateMachine<TContext>
    where TContext : class, new()
{
    public TStateMachine StateMachine { get; private set; }
    public TContext Context { get; private set; }

    public void Initialize(TStateMachine stateMachine, TContext context)
    {
        StateMachine = stateMachine;
        Context = context ?? throw new NullReferenceException();
    }

    public virtual void EnterState() {}
    public virtual void UpdateState() {}
}
