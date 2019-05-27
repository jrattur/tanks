using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoostPowerup : MonoBehaviour
{
    public Vector3 force = Vector3.forward;
    public bool destroyOnUse = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            other.GetComponent<Rigidbody>().AddForce(other.transform.TransformVector(force), ForceMode.Impulse);
            if (destroyOnUse) { Destroy(gameObject); }
        }
    }
}
