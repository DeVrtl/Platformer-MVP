using UnityEngine;
using Zenject;

public abstract class EnemyPresenter<TModel> : MonoBehaviour
    where TModel : class
{
    [Inject] public TModel Model { get; private set; }

    protected virtual void Awake()
    {
        DependencyScopes.Game.Inject(this);
    }
}
