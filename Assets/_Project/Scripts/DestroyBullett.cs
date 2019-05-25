﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullett : MonoBehaviour
{
    private float birthTime;
    [SerializeField] private float lifeTime = 5f;

    public GameObject explosion;
    private void Start()
    {
        birthTime = Time.time;
    }

    public void Update()
    {
        if (Time.time > birthTime + lifeTime) { Destroy(gameObject); }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (explosion != null) {
            Instantiate(explosion, collision.GetContact(0).point, transform.rotation);
        }
        Destroy(gameObject);
    }
}
