using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullett : MonoBehaviour
{
    private float birthTime;
    [SerializeField] private float lifeTime = 5f;

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
        Destroy(gameObject);
    }
}
