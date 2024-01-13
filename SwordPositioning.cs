using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPositioning : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private SpriteRenderer playerSpriteRenderer;
    private SpriteRenderer swordSpriteRenderer;

    private void Start()
    {
        // Lấy tham chiếu đến transform và SpriteRenderer của Player
        playerTransform = transform.parent;
        playerSpriteRenderer = playerTransform.GetComponent<SpriteRenderer>();

        // Lấy tham chiếu đến SpriteRenderer của Sword
        swordSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Đặt vị trí của Sword dựa trên hướng di chuyển
        if (playerSpriteRenderer.flipX == true)
        {
            // Sword nằm bên trái của Player
            swordSpriteRenderer.flipX = true;
            transform.localPosition = new Vector3(-0.8f, -1f, 0f);
        }
        else if (playerSpriteRenderer.flipX == false)
        {
            // Sword nằm bên phải của Player
            swordSpriteRenderer.flipX = false;
            transform.localPosition = new Vector3(0.8f, -1f, 0f);
        }
    }
}