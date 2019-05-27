using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankGuns : MonoBehaviour
{
    public GameObject[] weapons;

    public Transform endOfBarrel;

    private int selectedWeapon = 0;

    public Animator barrelAnimator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){ selectedWeapon = 0; }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) { selectedWeapon = 1; }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) { selectedWeapon = 2; }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) { selectedWeapon = 3; }
        else if (Input.GetKeyDown(KeyCode.Alpha5)) { selectedWeapon = 4; }
        else if (Input.GetKeyDown(KeyCode.Alpha6)) { selectedWeapon = 5; }


        if (Input.GetButtonDown("Fire1")) {
            Instantiate(weapons[selectedWeapon], endOfBarrel.position, endOfBarrel.rotation);
            barrelAnimator.SetBool("Fire", true);
        }
    }
}
