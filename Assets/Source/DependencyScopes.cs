using Zenject;

public static class DependencyScopes 
{
    public static DiContainer Game { get; private set; }

    public static void Init()
    {
        Game = new DiContainer();
    }

    public static void Dispose()
    {
        Game.UnbindAll();
        Game = null;
    }
}
