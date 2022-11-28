using UnityEngine;
using UnityEngine.Events;

public class PlayerTransformable
{
    private const int RaycastDistance = 1;
    private const string Jump = "Jump";

    public readonly PlayerStat Speed = new();
    public readonly PlayerStat JumpForce = new();
    
    public event UnityAction<float> Jumped;

    public void Move(Transform transform, float horizontal)
    {
        transform.position += new Vector3(horizontal, 0) * Time.deltaTime * Speed.Current;
    }

    public void DoJump(Transform transform, LayerMask groundLayerMask)
    {
        var raycastHit = Physics2D.Raycast(transform.position, Vector2.down, RaycastDistance, groundLayerMask);

        if (raycastHit.collider != null && Input.GetButtonDown(Jump))
        {
            Jumped?.Invoke(JumpForce.Current);
        }
    }

    public void Flip(float movement, Transform transform)
    {
        var angle = movement < 0 ? 180 : 0;

        CalculateEulerAngles(angle, transform);
    }

    private void CalculateEulerAngles(float y, Transform transform)
    {
        transform.eulerAngles = new Vector3(0, y);
    }
}
