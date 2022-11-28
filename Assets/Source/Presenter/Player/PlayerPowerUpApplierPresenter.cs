public class PlayerPowerUpApplierPresenter : Presenter<PlayerPowerUpApplier>
{
    private void Awake()
    {
        DependencyScopes.Game.Inject(this);
    }
}
