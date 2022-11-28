public interface IPowerUpVisitor
{
    public void Visit(SpeedPowerUp powerUp, PlayerTransformable playerTransformable);
    public void Visit(JumpForcePowerUp powerUp, PlayerTransformable playerTransformable);
}
