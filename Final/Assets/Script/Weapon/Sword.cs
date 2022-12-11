using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : BaseWeapon
{
    private Coroutine attackDuration_coroutine;
    public float attackDuration;
    [SerializeField] PolygonCollider2D polygonCollider;

    public override void Attack()
    {
        canAttack = true;
        polygonCollider.enabled = true;
        if (attackDuration_coroutine == null)
        {
            attackDuration_coroutine = StartCoroutine("AttackDuration");
        }
    }

    private IEnumerator AttackDuration()
    {
        yield return new WaitForSeconds(attackDuration);
        canAttack = false;
        polygonCollider.enabled = false;
        attackDuration_coroutine = null;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canAttack)
        {
            IDamageable target = collision.GetComponent<IDamageable>();
            if (target != null)
            {
                target.RecieveDamage(damage + extraDamage);
            }
        }
    }
}
