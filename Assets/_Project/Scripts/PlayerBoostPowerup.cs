using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoostPowerup : MonoBehaviour
{

    public float boostForce = 1500000f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            other.GetComponent<Rigidbody>().AddForce(other.transform.TransformVector(Vector3.forward) * boostForce, ForceMode.Impulse);
            Destroy(gameObject);
        }
    }
}
