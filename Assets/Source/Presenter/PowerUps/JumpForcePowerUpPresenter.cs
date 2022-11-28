using UnityEngine;
using Zenject;

public class JumpForcePowerUpPresenter : MonoBehaviour
{
    [Inject] private JumpForcePowerUp _model;

    private void Awake()
    {
        DependencyScopes.Game.Inject(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerTransformablePresenter transformable))
        {
            if (collision.TryGetComponent(out PlayerPowerUpApplierPresenter powerUpApplier))
            {
                powerUpApplier.Model.Visit(_model, transformable.Model);
                Destroy(gameObject);
            }
        }
    }
}
