using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float throttleForce = 10f;
    [SerializeField] private float slideValue = 0f;
    [SerializeField] private float topSpeed = 100f;
    [SerializeField] private float torque = 5f;
    [SerializeField] private float turretHorizontalSpeed = 2f;
    [SerializeField] private float turretVerticalSpeed = 2f;

    public GameObject wheelObjectsLeft, wheelObjectRight;
    public GameObject turretHorizontal, turretVertical;

    private WheelCollider[] wheelsLeft, wheelsRight;

    [SerializeField] private bool grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        wheelsLeft = wheelObjectsLeft.GetComponentsInChildren<WheelCollider>();
        wheelsRight = wheelObjectRight.GetComponentsInChildren<WheelCollider>();
        rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        grounded = false;
        foreach (WheelCollider wheel in wheelsLeft) { if (wheel.isGrounded) { grounded = true; } }
        foreach (WheelCollider wheel in wheelsRight) { if (wheel.isGrounded) { grounded = true; } }

        ApplyForcesTank();
        Slide();

    }
    private float[] GetInputTank()
    {
        float forwards = Input.GetAxis("Vertical");
        float turning = Input.GetAxis("Horizontal");
        return new float[] { forwards, turning };
    }

    private void Slide()
    {
     /*   Vector3 latforce = (Vector3.Dot(transform.right, rb.velocity) * transform.right);

        float latforcemag = latforce.magnitude;
        if (latforce.magnitude > slideValue)
        {
            latforce *= slideValue / latforce.magnitude;
        }

        rb.AddForce(-latforce * rb.mass, ForceMode.Impulse);*/
    }

    private void ApplyForcesTank()
    {


        if (Input.GetAxis("Horizontal") > 0.01)
        {
            foreach (WheelCollider wheel in wheelsLeft) { wheel.motorTorque = torque; }
            foreach (WheelCollider wheel in wheelsRight) { wheel.motorTorque = 0.66f * -torque; }

            //rb.AddTorque(Vector3.up * (torque * Input.GetAxis("Horizontal")));
        }
        else if (Input.GetAxis("Horizontal") < -0.01)
        {
            foreach (WheelCollider wheel in wheelsRight) { wheel.motorTorque = torque; }
            foreach (WheelCollider wheel in wheelsLeft) { wheel.motorTorque = 0.66f * -torque; }

            //rb.AddTorque(Vector3.up * (torque * Input.GetAxis("Horizontal")));
        }
        else
        {
            foreach (WheelCollider wheel in transform.GetComponentsInChildren<WheelCollider>())
            {
                wheel.motorTorque = 0f;
            }
        }
        if (Input.GetAxis("Vertical") > 0 && grounded)
        {
            Vector3 throttle = transform.TransformDirection(new Vector3(0f, 0f, throttleForce));

            if (rb.velocity.magnitude > (topSpeed - 2f))
            {
                throttle = throttle / (1 / (topSpeed - rb.velocity.magnitude));
            }

            if (rb.velocity.magnitude < topSpeed)
                rb.AddForce(throttle);

            //foreach (WheelCollider wheel in transform.GetComponentsInChildren<WheelCollider>())
            //{
            //    wheel.motorTorque = throttleForce;
            //}
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            Vector3 throttle = transform.TransformDirection(new Vector3(0f, 0f, throttleForce));

            if (rb.velocity.magnitude > (topSpeed - 2f))
            {
                throttle = throttle / (1 / (topSpeed - rb.velocity.magnitude));
            }

            if (rb.velocity.magnitude < topSpeed)
                rb.AddForce(-throttle);

            //foreach (WheelCollider wheel in transform.GetComponentsInChildren<WheelCollider>())
            //{
            //    wheel.motorTorque = throttleForce;
            //}
        }



        turretHorizontal.transform.Rotate(new Vector3(0f, Input.GetAxis("Mouse X") * turretHorizontalSpeed));
        turretVertical.transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * turretVerticalSpeed, 0f));
    }
}
