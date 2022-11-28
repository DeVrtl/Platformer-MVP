using UnityEngine;

public class FlyChasingState : FlyState
{
    public override void UpdateState()
    {
        if (Zone.Target)
        {
            Vector3 direction = (Zone.Target.position - Transform.position).normalized;
            Transform.position += direction * Time.deltaTime;
        }
        else
        {
            Fly.SwitchState(Fly.ReturnState);
        }
    }
}
