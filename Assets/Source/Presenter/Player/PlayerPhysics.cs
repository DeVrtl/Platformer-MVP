using System;
using UnityEngine;

public class PlayerPhysics : MonoBehaviour
{
	[SerializeField] private float _initialForce;

	private Rigidbody2D _rigidbody;
	private float _jumpForce;

	private void OnValidate()
	{
		_initialForce = Mathf.Clamp(_initialForce, 0, float.MaxValue);
	}

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		SetJumpForce(_initialForce);
	}

	public void SetJumpForce(float force)
	{
		if (force < 0)
		{
			throw new ArgumentException();
		}

		_jumpForce = force;
	}
		
	public void Jump()
	{
		_rigidbody.AddForce(Vector2.up * _jumpForce);
	}
}