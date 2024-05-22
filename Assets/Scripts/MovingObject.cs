using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] Vector2 velocity;
    [SerializeField] float moveSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(velocity.x * moveSpeed, velocity.y * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = velocity;
    }

}
