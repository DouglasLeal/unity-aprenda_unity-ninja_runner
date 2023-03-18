using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal = 0;
    private float vertical = 0;
    private float maxY = -0.317f;
    private float minY = -0.66f;
    private float maxX = 1.5f;
    private float minX = -1.5f;

    [SerializeField]
    private float velocidadeMovimento = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if(transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, maxY);

        }else if (transform.position.y < minY)
        {
            transform.position = new Vector2(transform.position.x, minY);
        }else if (transform.position.x > maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
        else if (transform.position.x < minX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
        else
        {
            rb.velocity = new Vector2(horizontal * velocidadeMovimento, vertical * velocidadeMovimento);
        }        
    }
}
