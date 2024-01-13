using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public int damageAmount = 10; // Sát thương của vũ khí
    [SerializeField] private Animator anim;
    [SerializeField] private AudioSource punch;

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {
            // Xử lý khi va chạm với kẻ địch
            if (!punch.isPlaying)
            {
                punch.Play();
            }
            Debug.Log("Player collided with an enemy!");
            anim.SetTrigger("IsHitEnemy");
        }
    }


}
