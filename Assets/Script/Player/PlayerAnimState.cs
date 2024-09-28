using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimState : MonoBehaviour
{
    Animator animator;
    [SerializeField] Animator AttackFX;

    int attackRepeat = 10;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            attackRepeat = 10 / GameManger.instance.playerData.AttackPower;
            GameManger.instance.isAttacking = true;

            animator.Play("Idle");
            AttackFX.gameObject.SetActive(true);
            Invoke(nameof(ResumeRunAnim), AttackFX.GetCurrentAnimatorStateInfo(0).length * attackRepeat);
        }
    }

    void ResumeRunAnim()
    {
        GameManger.instance.isAttacking = false;

        animator.Play("Run");
        AttackFX.gameObject.SetActive(false);
    }
}
