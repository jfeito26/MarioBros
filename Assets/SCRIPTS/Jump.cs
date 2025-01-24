using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public LayerMask groundMask;
    private Rigidbody2D _rb;
    public float JumpForce = 4f, sphereRadius = 1f;
    private bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //void Jump()
    //{
    //    _currentState = PlayerState.Jumping;
    //}
}
