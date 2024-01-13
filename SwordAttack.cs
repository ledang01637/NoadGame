using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxColliderAttack;
    [SerializeField] private SpriteRenderer swordSpriteRenderer;
    [SerializeField] private AudioSource Sword;

    public float attackDuration = 0.5f;
    public float attackCooldown = 1f;

    private bool isAttacking = false;
    private float attackTimer = 0f;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        boxColliderAttack.enabled = false;
        if (isAttacking)
        {
            attackTimer += Time.deltaTime;

            if (attackTimer >= attackDuration)
            {
                isAttacking = false;
                attackTimer = 0f;
                animator.SetBool("IsAttacking", false);
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1"))
            {
                // Đặt vị trí của Sword dựa trên hướng di chuyển
                if (swordSpriteRenderer.flipX == true)
                {
                    boxColliderAttack.offset = new Vector2(0.2f, 0.5f);
                    boxColliderAttack.size = new Vector2(1.8f, 3f);
                    print("1");
                    Attack();
                }
                else if (swordSpriteRenderer.flipX == false)
                {
                    boxColliderAttack.offset = new Vector2(-0.2f, 0.5f);
                    boxColliderAttack.size = new Vector2(1.8f, 3f);
                    print("2");
                    Attack();
                }
                isAttacking = true;
            }

        }
    }

    private void Attack()
    {
        if (!Sword.isPlaying)
        {
            Sword.Play();
        }
        animator.SetBool("IsAttacking", true);
        boxColliderAttack.enabled = true;
        // Thực hiện logic tấn công ở đây
    }
}
