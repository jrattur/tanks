using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretGun : MonoBehaviour
{
    private GameObject player;
    Rigidbody rb;
    public GameObject barrel;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 relative = transform.InverseTransformPoint(player.transform.position + (player.GetComponent<Rigidbody>().velocity * 0.66f));
        float angle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;

        if (angle > 2f) { rb.AddTorque(0f, 5f, 0f); }
        else if (angle < 2f) { rb.AddTorque(0f, -5f, 0f); }

        float verticalAngle = Mathf.Atan2(relative.y, relative.z) * Mathf.Rad2Deg;

        barrel.transform.localEulerAngles = new Vector3(
           -verticalAngle,
           barrel.transform.localEulerAngles.y,
           barrel.transform.localEulerAngles.z);

        //Debug.Log(barrel.transform.localEulerAngles);

        Debug.Log(verticalAngle);
    }


}
