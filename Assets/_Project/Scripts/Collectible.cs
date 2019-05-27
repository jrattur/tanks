using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public bool destroyOnUse = true;
    GameManager.LevelPhase levelPhase = GameManager.LevelPhase.second;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.NextPhase();
            if (destroyOnUse) { Destroy(gameObject); }
        }
    }
}
