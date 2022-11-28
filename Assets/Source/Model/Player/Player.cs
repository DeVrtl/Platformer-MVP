using UnityEngine.Events;
using UnityEngine;

public class Player
{
    public float Health { get; private set; }
    private float _minHealth = 0;

    public float MaxHealth { get; private set; } = 3;

    public event UnityAction Died;
    public event UnityAction<float> HealthChanged;

    public void ApplyConfig(PlayerConfig config)
    {
        MaxHealth = config.MaxHealth;
    }

    public void Initialize()
    {
        Health = MaxHealth;

        HealthChanged?.Invoke(Health);
    }

    public void TakeDamage(float damage)
    {
        Health -= Mathf.Min(Health, damage);
        HealthChanged?.Invoke(Health);

        if (Health <= _minHealth)
        {
            Died?.Invoke();
        }
    }
}