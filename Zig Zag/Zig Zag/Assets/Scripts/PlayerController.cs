using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float moveSpeed;
    private Rigidbody rb;
    private int direction = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (direction == 0)
                direction = 1;
            else
                direction = 0;
        }
        Move();
        rb.velocity += new Vector3(0f, 0f, 3f);
    }

    private void Move()
    {
        if (direction == 0)
            rb.velocity = Vector3.right * moveSpeed;
        else
            rb.velocity = Vector3.up * moveSpeed;
    }
}
