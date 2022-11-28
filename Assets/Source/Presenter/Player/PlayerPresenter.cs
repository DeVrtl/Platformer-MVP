using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerPresenter : Presenter<Player>
{
    [SerializeField] private PlayerConfig _playerConfig;

    private Rigidbody2D _rigidbody;
    private Collider2D _collider;
    private PlayerTransformablePresenter _transformablePresenter;
    private Animator _animator;

    private void OnEnable()
    {
        TrySubscribeOnModel();
    }

    private void OnDisable()
    {
        TryUnsubscribeOnModel();
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
        _transformablePresenter = GetComponent<PlayerTransformablePresenter>();
        _animator = GetComponent<Animator>();

        DependencyScopes.Game.Inject(this);

        Model.ApplyConfig(_playerConfig);
        Model.Initialize();
    }

    protected override void SubscribeOnModel()
    {
        Model.Died += OnDied;
    }

    protected override void UnsubscribeFromModel()
    {
        Model.Died -= OnDied;
    }

    private void OnDied()
    {
        _rigidbody.AddForce(Vector2.up * _playerConfig.DeathJumpForce);
        _collider.enabled = false;
        _transformablePresenter.enabled = false;
        _animator.Play(AnimatorPlayerController.States.Dead);
    }
}
