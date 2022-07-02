using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personatge : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _vel;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _vel = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float inputHoritzontal = Input.GetAxisRaw("Horizontal") * _vel;
        _rigidbody.velocity = new Vector2(inputHoritzontal, _rigidbody.velocity.y);
    }
}
