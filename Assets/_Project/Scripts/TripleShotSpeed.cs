using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotSpeed : MonoBehaviour
{
    public float tripleShotSpeed = 1f;
    private TurretAutoFire turretAutoFire;

    public void Start()
    {
        turretAutoFire = GetComponent<TurretAutoFire>();
    }

    public void Update()
    {
        TripleShot tripleShot = turretAutoFire.bullet.GetComponent<TripleShot>();
        if (tripleShot != null) { tripleShot.speed = tripleShotSpeed; }
    }
}
