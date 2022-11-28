using UnityEngine;

public class FlyReturnState : FlyState
{
    public override void UpdateState()
    {
        if (Zone.Target == null)
        {
            Transform.position = Vector2.MoveTowards(Transform.position,
                Fly.IdleState.CurrentPosition, Time.deltaTime);
        }
        else if (Zone.Target != null)
        {
            Fly.SwitchState(Fly.ChasingState);
        }
        else if (Transform.position == Fly.IdleState.CurrentPosition)
        {
            Fly.SwitchState(Fly.IdleState);
        }
    }
}
