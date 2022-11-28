using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/Player Config")]
public class PlayerConfig : ScriptableObject
{
    [SerializeField] private float _baseSpeed;
    [SerializeField] private float _baseJumpForce;
    [SerializeField] private float _deathJumpForce;
    [SerializeField] private float _maxHealth;
    [SerializeField] private LayerMask _groundLayerMask;
    
    public float BaseSpeed => _baseSpeed;
    public float BaseJumpForce => _baseJumpForce;
    public float DeathJumpForce => _deathJumpForce;
    public float MaxHealth => _maxHealth;
    public LayerMask GroundLayerMask => _groundLayerMask;

    private void OnValidate()
    {
        _baseSpeed = Mathf.Clamp(_baseSpeed, 0, float.MaxValue);
        _baseJumpForce = Mathf.Clamp(_baseJumpForce, 0, float.MaxValue);
        _deathJumpForce = Mathf.Clamp(_deathJumpForce, 0, float.MaxValue);
        _maxHealth = Mathf.Clamp(_maxHealth, 0, float.MaxValue);
    }
}
