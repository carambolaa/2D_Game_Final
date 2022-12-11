using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    protected bool canAttack;
    public int damage;
    public int extraDamage;

    public abstract void Attack();
}
