using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform platerStartPosition;
    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        transform.position = platerStartPosition.position;
    }
    void Update()
    {
        float moveInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 10);
        }
    }
}
