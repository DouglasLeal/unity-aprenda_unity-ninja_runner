using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal = 0;
    private float vertical = 0;

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

        rb.velocity = new Vector2(horizontal * velocidadeMovimento, vertical * velocidadeMovimento);
    }
}
