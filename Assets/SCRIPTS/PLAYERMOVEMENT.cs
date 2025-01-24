using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState { IDLE, WALKING }
public class PLAYERMOVEMENT : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = 3f;
    private Vector2 _dir;
    private PlayerState _currentState;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _dir = new Vector2(Input.GetAxis("Horizontal"), 0);

        if (_dir.magnitude == 0)
        {
            _currentState = PlayerState.IDLE;
        }
        else
        {
            _currentState = PlayerState.WALKING;
        }
        //Jump();
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(_dir.x * speed, _rb.velocity.y);
    }

    public PlayerState GetCurrentState()
    {
        return _currentState;
    }

    public Vector2 GetDirection()
    {
        return _dir;
    }

}
