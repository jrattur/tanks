using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAutoFire : MonoBehaviour
{
    public GameObject bullet;
    public Transform endOfBarrel;
    public float shootTime;
    private float timer = 0f;
    public float shotSpeed = 1f;

    private void Start()
    {
        timer = Random.Range(0.1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        bullet.GetComponent<Bullet>().speed = shotSpeed;

        timer += Time.deltaTime;
        if (timer > shootTime) {
            timer = 0f;
            Instantiate(bullet, endOfBarrel.transform.position, endOfBarrel.transform.rotation);
        }
    }
}
