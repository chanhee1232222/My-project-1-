using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    Animator animator;

    ParticleSystem dust;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        dust = GetComponentInChildren<ParticleSystem>();
    }

    void Start()
    {
        transform.position = playerStartPosition.position;
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        float moveInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moveInput_X * moveSpeed, rigid.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            soundmanager.Instance.PlaySFX("jump");
            CreateDust();
            rigid.velocity = new Vector2(rigid.velocity.x, 30);
        }
    }

    void CreateDust() 
    {
        dust.Play();
    }
}
