using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : BaseWeapon
{
    public int damge = 2;
    public float speed = 20f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Destroy(gameObject);
    }
}
