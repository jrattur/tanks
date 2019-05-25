using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAutoFire : MonoBehaviour
{
    public GameObject bullet;
    public Transform endOfBarrel;
    public float shootTime;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootTime) {
            timer = 0f;
            Instantiate(bullet, endOfBarrel.transform.position, endOfBarrel.transform.rotation);
        }
    }
}
