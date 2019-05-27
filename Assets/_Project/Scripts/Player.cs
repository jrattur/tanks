using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, Damagesble
{
    public int coins = 0;
    public Text coinDisplay, healthDisplay;

    public int Health = 100;
    public void AddCoin()
    {
        coins++;
        coinDisplay.text = "Coins: " + coins;
    }

    public void Die()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().gameOver();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        healthDisplay.text = "Health: " + Health;
        if (Health <= 0) { Die(); }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
