using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personatge : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _velCorrer;
    private float _velSaltar;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _velCorrer = 5f;
        _velSaltar = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float inputHoritzontal = Input.GetAxisRaw("Horizontal") * _velCorrer;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _velSaltar);
        }
        _rigidbody.velocity = new Vector2(inputHoritzontal, _rigidbody.velocity.y);
    }
}
