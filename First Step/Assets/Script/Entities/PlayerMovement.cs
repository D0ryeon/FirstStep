using System.Collections;
using System.Collections.Generic;
using System.Security.Claims;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerCharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

   
    [SerializeField] private SpriteRenderer characterRenderer;

    private void Awake()
    {
        _controller = GetComponent<PlayerCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnLookEvent += OnAim;
    }


    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }


    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
