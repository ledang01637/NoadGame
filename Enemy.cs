using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100; // Máu của kẻ địch

    private void Update()
    {
        // Kiểm tra nếu máu <= 0, tiêu diệt kẻ địch
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


    public void TakeDamage(int damageAmount)
    {
        // Trừ điểm máu dựa trên damageAmount
        health -= damageAmount;

        // Điều gì xảy ra khi kẻ địch bị đánh
        // Ví dụ: hiệu ứng, âm thanh, v.v.
    }

}
