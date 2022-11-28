using UnityEngine.SceneManagement;

public class GameServicesContainer
{    
    public static void Init()
    {
        DependencyScopes.Init();

        DependencyScopes.Game.Bind<PlayerTransformable>().AsTransient();
        DependencyScopes.Game.Bind<Player>().AsSingle();
        DependencyScopes.Game.Bind<Mouse>().AsTransient();
        DependencyScopes.Game.Bind<Fly>().AsTransient();
        DependencyScopes.Game.Bind<SpeedPowerUp>().AsTransient();
        DependencyScopes.Game.Bind<JumpForcePowerUp>().AsTransient();
        DependencyScopes.Game.Bind<PlayerPowerUpApplier>().AsTransient();
        
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
    }
}
