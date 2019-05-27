using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullett : MonoBehaviour
{
    private float birthTime;
    [SerializeField] private float lifeTime = 5f;
    [SerializeField] private int damage = 10;

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
        Damagesble damagesble = collision.gameObject.GetComponent<Damagesble>();
        if (damagesble != null) { damagesble.TakeDamage(damage); }

        if (explosion != null) {
            Instantiate(explosion, collision.GetContact(0).point, transform.rotation);
        }
        Destroy(gameObject);
    }
}
