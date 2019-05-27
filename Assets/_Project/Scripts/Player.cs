using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int coins = 0;
    public Text coinDisplay;

    public void AddCoin()
    {
        coins++;
        coinDisplay.text = "Coins: " + coins;
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
