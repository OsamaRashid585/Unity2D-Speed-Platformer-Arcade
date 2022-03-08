using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 30;
    private float _jumpPower = 10;
    private bool _isGrounded;
    private Rigidbody2D _rb;
    private SpriteRenderer _sp;
    private float _inpX;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        _inpX = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        Movement();

        FaceFlip();
    }

    private void Movement()
    {
        _rb.AddForce(Vector2.right.normalized * Time.deltaTime * _inpX * _speed, ForceMode2D.Impulse);

        if (Input.GetKey((KeyCode.Space)) && _isGrounded)
        {
            _rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }

    private void FaceFlip()
    {
        if (_inpX < 0)
        {
            _sp.flipX = true;
        }
        if(_inpX >= 0)
        {
            _sp.flipX = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }

}
