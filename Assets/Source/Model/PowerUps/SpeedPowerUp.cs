public class SpeedPowerUp : PowerUp
{
    public override void Accept(IPowerUpVisitor visitor, PlayerTransformable playerTransformable)
    {
        visitor.Visit(this, playerTransformable);
    }
}
