public class PlayerPowerUpApplier : IPowerUpVisitor
{
    private const string SpeedModifierId = "PowerUp";
    private const string JumpForceModifierId = "JumpForce";
    
    public void Visit(SpeedPowerUp powerUp, PlayerTransformable playerTransformable)
    {
        playerTransformable.Speed.AddModifier(SpeedModifierId, 3f);
    }

    public void Visit(JumpForcePowerUp powerUp, PlayerTransformable playerTransformable)
    {
        playerTransformable.JumpForce.AddModifier(JumpForceModifierId, 2f);
    }
}
