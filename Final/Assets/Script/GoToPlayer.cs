using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPlayer : MonoBehaviour
{
    public bool isTrackingPlayer = true;
    public int moveSpeed = 5;
    GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player != null && isTrackingPlayer == true)
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log(this.gameObject.name);

            if (this.gameObject.name == "Coin(Clone)")
            {
                GameManager.instance.AddGold(1);
            }
            else if(this.gameObject.name == "Diamond(Clone)")
            {
                GameManager.instance.AddEXP(1);
            }
            Destroy(this.gameObject);
        }
    }
}
