using UnityEngine;

public class MouseMovingRightState : MouseState
{
    public override void EnterState()
    {
        Transform.eulerAngles = new Vector3(0, -180, 0);
    }

    public override void UpdateState()
    {
        Transform.Translate(Vector2.right * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(Point.position, Vector2.down, 2f);

        if (groundInfo.collider == false)
        {
            Mouse.SwitchState(Mouse.MovingLeft);
        }
    }
}