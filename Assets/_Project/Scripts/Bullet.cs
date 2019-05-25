using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1f;
    public GameObject muzzleflare;

    private void Start()
    {
        if (muzzleflare != null)
        {
            Instantiate(muzzleflare, transform.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        transform.SetPositionAndRotation(transform.position + transform.TransformVector(Vector3.forward * speed), transform.rotation);
    }
}
