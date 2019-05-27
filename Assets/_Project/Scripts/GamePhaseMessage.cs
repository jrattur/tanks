using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePhaseMessage : MonoBehaviour
{
    public float displayTime = 5f;
    private float timer = 0f;

    public void SetMessage(string message) { GetComponentInChildren<Text>().text = message; }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > displayTime) { Destroy(gameObject); }
    }
}
