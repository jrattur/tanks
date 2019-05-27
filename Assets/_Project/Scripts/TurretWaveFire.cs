using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretWaveFire : MonoBehaviour
{
    private GameObject player;
    Rigidbody rb;
    public GameObject barrel;

    public float barrelMin = -26f, barrelMax = 26f;

    public enum Direction {left,right }
    public Direction direction = Direction.left;

    public float swingAngle = 15f;

    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        Vector3 relative = transform.InverseTransformPoint(player.transform.position + (player.GetComponent<Rigidbody>().velocity * 0.66f));
        float angle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;
        //transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, angle, transform.localEulerAngles.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float direction = 0f;
        //Vector3 relative = transform.InverseTransformPoint(player.transform.position + (player.GetComponent<Rigidbody>().velocity * 0.66f));
        //float angle = Mathf.Atan2(relative.x, relative.z) * Mathf.Rad2Deg;


        float turretAngle = transform.rotation.eulerAngles.y;
        if (turretAngle > 180f) { turretAngle -= 360f; }

        if (direction == Direction.left)
        {
            rb.AddTorque(0f, -speed, 0f);
            if (turretAngle < -swingAngle) { direction = Direction.right; }
        }
        else {
            rb.AddTorque(0f, speed, 0f);
            if (turretAngle > swingAngle) { direction = Direction.left; }
        }

    }

}
