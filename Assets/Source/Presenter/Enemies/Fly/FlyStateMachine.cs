using UnityEngine;

public class FlyStateMachine : StateMachine<FlyContext>
{
    [SerializeField] private FlyZone _zone;
    
    public readonly FlyIdleState IdleState = new();
    public readonly FlyChasingState ChasingState = new();
    public readonly FlyReturnState ReturnState = new();

    private void Awake()
    {
        Context.Transform = transform;
        Context.FlyZone = _zone;

        IdleState.Initialize(this, Context);
        ChasingState.Initialize(this, Context); 
        ReturnState.Initialize(this, Context);
    }

    private void Start()
    {
        CurrentState = IdleState;
        CurrentState.EnterState();
    }

    private void Update()
    {
        CurrentState.UpdateState();
    }
    
    public void SwitchState(FlyState state)
    {
        CurrentState = state;
        state.EnterState();
    }
}
