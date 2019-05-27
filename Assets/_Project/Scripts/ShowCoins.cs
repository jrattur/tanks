using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCoins : MonoBehaviour
{

    public void UpdateCoinText(string text)
    {
        GetComponentInChildren<Text>().text = text;
    }

}
