using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool canSpawn;
    public float levelTime;

    public int gold;
    public TextMeshProUGUI coinCounter;
    public int exp;

    public int extraDamage;

    public int batKilled;
    public int mushroomKilled;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        coinCounter = GameObject.Find("CoinNumber").GetComponent<TextMeshProUGUI>();
    }

    public void AddGold(int amount)
    {
        gold += amount;
        coinCounter.text = gold.ToString();
    }

    public void AddEXP(int amount)
    {
        exp += amount;
    }

    public void KillCountReset()
    {
        batKilled = 0;
        mushroomKilled = 0;
    }

    private IEnumerator LevelTimer()
    {
        yield return new WaitForSeconds(levelTime);
        //spawn level boss here
    }

    public void EndLevel()
    {
        //end current level
        //show result panel
        //go next level

    }
}
