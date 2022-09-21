using System;
using System.Diagnostics;
using UnityEngine;

public class gunScript : MonoBehaviour
{

    public float range  = 20f;
    public float impactForce = 150;

    public Transform fpscamera;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            Fire();
        }
    }

    private void Fire() {
        RaycastHit hit;
        if(Physics.Raycast(FpsCam.position, fpsCam.forward, out hit, range)) {
            if(hit.rigidbody != null) {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
