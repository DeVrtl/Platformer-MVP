using UnityEngine;

public class MouseStateMachine : StateMachine<MouseContext>
{
    [SerializeField] private Transform _point;

    public readonly MouseMovingRightState MovingRight = new();
    public readonly MouseMovingLeftState MovingLeft = new();

    private void Awake()
    {
        Context.Transform = transform;
        Context.Point = _point;

        MovingRight.Initialize(this, Context);
        MovingLeft.Initialize(this, Context);
    }

    private void Start()
    {
        CurrentState = MovingRight;
        CurrentState.EnterState();
    }

    private void Update()
    {
        CurrentState.UpdateState();
    }

    public void SwitchState(MouseState state)
    {
        CurrentState = state;
        state.EnterState();
    }
}
