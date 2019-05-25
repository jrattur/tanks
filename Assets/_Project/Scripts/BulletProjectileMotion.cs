using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectileMotion : MonoBehaviour
{
    public float force;

    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward * force),ForceMode.Impulse);
    }
}
