using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _speed;

    [Inject] private Player _player;

    private float _targetHealthRatio;

    private void OnValidate()
    {
        _speed = Mathf.Clamp(_speed, 0, float.MaxValue);
    }

    private void OnEnable()
    {
        OnHealthChanged(_player.Health);
        _slider.value = _targetHealthRatio;

        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void Awake()
    {
        DependencyScopes.Game.Inject(this);
    }

    private void OnHealthChanged(float health)
    {
        _targetHealthRatio = health / _player.MaxHealth;
    }

    private void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _targetHealthRatio, _speed * Time.deltaTime);
    }
}