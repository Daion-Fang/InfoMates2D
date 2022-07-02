using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personatge : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _velCorrer;
    private float _velSaltar;

    // Variables pel control del salt del personatge:
    public Transform _centreZonaContacteTerra;
    public float _radiContacteTerra;
    public LayerMask _layerTerra;
    private bool _tocaTerra;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _velCorrer = 5f;
        _velSaltar = 6f;

        _tocaTerra = true;
    }

    // Update is called once per frame
    void Update()
    {
        //_tocaTerra = Physics2D.OverlapCircle(_centreZonaContacteTerra.position, _radiContacteTerra, _layerTerra);
        // 1.0f: un valor corresponent a l'amplada de la OverlapBox, més petit que l'amplada de BoxCollider2D del personatge.
        _tocaTerra = Physics2D.OverlapBox(_centreZonaContacteTerra.position, new Vector2(1.0f, _radiContacteTerra), 0f, _layerTerra);

        Debug.DrawRay(_centreZonaContacteTerra.position, Vector2.down * _radiContacteTerra, Color.green);

        if (Input.GetKeyDown(KeyCode.Space) && _tocaTerra)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _velSaltar);
        }

        float inputHoritzontal = Input.GetAxisRaw("Horizontal") * _velCorrer;
        _rigidbody.velocity = new Vector2(inputHoritzontal, _rigidbody.velocity.y);
    }
}
