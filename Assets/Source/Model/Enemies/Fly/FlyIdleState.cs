using UnityEngine;

public class FlyIdleState : FlyState
{
    public Vector3 CurrentPosition { get; private set; }

    public override void EnterState()
    {
        CurrentPosition = Transform.position;
    }

    public override void UpdateState()
    {
        if (Zone.Target != null)
        {
            Fly.SwitchState(Fly.ChasingState);
        }
    }
}
