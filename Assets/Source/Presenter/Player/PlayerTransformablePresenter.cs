using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Animator))]
public class PlayerTransformablePresenter : Presenter<PlayerTransformable>
{
    private const string Horizontal = "Horizontal";

    [SerializeField] private PlayerConfig _playerConfig;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    public void OnEnable()
    {
        TrySubscribeOnModel();
    }

    public void OnDisable()
    {
        TryUnsubscribeOnModel();
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();

        DependencyScopes.Game.Inject(this);

        Model.Speed.ApplyBase(_playerConfig.BaseSpeed);
        Model.JumpForce.ApplyBase(_playerConfig.BaseJumpForce);
    }

    private void Update()
    {
        float movement = Input.GetAxis(Horizontal);
        Model.Flip(movement, transform);

        Model.Move(transform, movement);
        _animator.SetFloat(AnimatorPlayerController.Params.Speed, Mathf.Abs(movement));

        Model.DoJump(transform, _playerConfig.GroundLayerMask);
    }

    protected override void SubscribeOnModel()
    {
        Model.Jumped += OnJumped;
    }

    protected override void UnsubscribeFromModel()
    {
        Model.Jumped -= OnJumped;
    }

    private void OnJumped(float jumpForce)
    {
        _rigidbody2D.AddForce(Vector2.up * jumpForce);
        _animator.Play(AnimatorPlayerController.States.Jump);
    }
}
