using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coalicionycambiodedireccion : MonoBehaviour
{
    private Rigidbody2D _comrigidbody2D;
    public float speed;
    public int xdirection;
    public int ydirection;
    private SpriteRenderer _comSpriteRenderer;

    void Awake()
    {
        _comrigidbody2D = GetComponent<Rigidbody2D>();
        _comSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        _comrigidbody2D.velocity = new Vector2(speed * xdirection, speed * ydirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "horizontal")
        {
            xdirection = xdirection * -1;
            _comSpriteRenderer.flipX = true;
            _comSpriteRenderer.flipY = false;
        }
        else if (collision.gameObject.tag == "vertical")
        {
            ydirection = ydirection * -1;
            _comSpriteRenderer.flipY = true;
            _comSpriteRenderer.flipX = false;
        }
    }
}
