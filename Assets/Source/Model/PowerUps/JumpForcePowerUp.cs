public class JumpForcePowerUp : PowerUp
{
    public override void Accept(IPowerUpVisitor visitor, PlayerTransformable playerTransformable)
    {
        visitor.Visit(this, playerTransformable);
    }
}
