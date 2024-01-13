using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Vector2 movement;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    [SerializeField] private AudioSource Walk;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        // Kích hoạt PlayerInput
        GetComponent<PlayerInput>().enabled = true;
    }

    private void OnDisable()
    {
        // Vô hiệu hóa PlayerInput
        GetComponent<PlayerInput>().enabled = false;
    }

    private void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }

    private void Update()
    {
        rb.velocity = movement * moveSpeed;

        if (movement.x < 0)
        {
            // Đặt hướng của nhân vật sang trái
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0)
        {
            // Đặt hướng của nhân vật sang phải
            spriteRenderer.flipX = false;
        }

        // Cập nhật trạng thái của Animator
        if (movement.magnitude > 0)
        {
            animator.SetBool("IsRunning", true); // Đang di chuyển
            if (!Walk.isPlaying)
            {
                Walk.Play();
            }
        }
        else
        {
            animator.SetBool("IsRunning", false); // Đứng yên
        }
    }

}
