using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : Bullet
{
    public GameObject projectile;
    public float angle = 20f;

    public int threeFiveSevenNiveShot = 3;

    public bool vert = false;

    // Start is called before the first frame update
    void Start()
    {
        projectile.GetComponent<Bullet>().speed = speed;
        Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, angle, 0f)));
        Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, -angle, 0f)));

        if (vert) {
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(angle, 0f, 0f)));
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(-angle, 0f, 0f)));
        }

        if (threeFiveSevenNiveShot > 3)
        {
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, angle * 2, 0f)));
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, -angle * 2, 0f)));
            if (vert)
            {
                Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(angle * 2, 0f, 0f)));
                Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(-angle * 2, 0f, 0f)));
            }
        }
        if (threeFiveSevenNiveShot > 5)
        {
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, angle * 3, 0f)));
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, -angle * 3, 0f)));
            if (vert)
            {
                Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(angle * 3, 0f, 0f)));
                Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(-angle * 3, 0f, 0f)));
            }
        }
        if (threeFiveSevenNiveShot > 7)
        {
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, angle * 4, 0f)));
            Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, -angle * 4, 0f)));
            if (vert)
            {
                Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(angle * 4, 0f, 0f)));
                Instantiate(projectile, transform.position + transform.TransformVector(Vector3.forward), Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(-angle * 4, 0f, 0f)));
            }
        }

        Destroy(gameObject);
    }
}
