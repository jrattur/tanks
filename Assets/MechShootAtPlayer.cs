using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechShootAtPlayer : MonoBehaviour
{
    public GameObject body;
    private GameObject player;
    private float shotActivateTimer = 0f;
    public float shootActivateTime = 5;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        shotActivateTimer += Time.deltaTime;
        if (shotActivateTimer > shootActivateTime) {

            Vector3 direction = player.transform.position - body.transform.position;
            float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            //Quaternion zzz = Quaternion.Euler(new Vector3(body.transform.rotation.eulerAngles.x, angle, body.transform.rotation.eulerAngles.z));
            Quaternion zzz = Quaternion.AngleAxis(-angle, Vector3.forward);

            Quaternion rotX = Quaternion.Euler(angle, 0, 0); // Pitch 45 degrees
            Quaternion rotY = Quaternion.Euler(0, 0f, 0); // Yaw 45 degrees

            Quaternion rotation;

            rotation = Quaternion.identity;
            rotation = rotY * rotation; // Rotate around global y axis
            rotation = rotX * rotation; // Rotate around global x axis
            Debug.Log(rotation.eulerAngles);

            body.transform.rotation = Quaternion.Slerp(body.transform.rotation, zzz, Time.deltaTime * rotationSpeed);


        }
    }
}
