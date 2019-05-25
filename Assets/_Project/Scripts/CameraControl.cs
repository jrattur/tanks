using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject camera1, camera2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")) {
            camera1.SetActive(!camera1.activeInHierarchy);
            camera2.SetActive(!camera2.activeInHierarchy);
        }
    }
}
