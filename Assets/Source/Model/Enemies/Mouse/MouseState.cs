using UnityEngine;

public abstract class MouseState : State<MouseStateMachine, MouseContext>
{
    public MouseStateMachine Mouse => StateMachine;
    public Transform Point => Context.Point;
    public Transform Transform => Context.Transform;
}
