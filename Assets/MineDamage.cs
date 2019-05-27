using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineDamage : MonoBehaviour
{
    public int damage;

    public void OnCollisionEnter(Collision collision)
    {
        Damagesble damagesble = collision.gameObject.GetComponent<Damagesble>();
        if (damagesble != null) { damagesble.TakeDamage(damage); }
    }
}
