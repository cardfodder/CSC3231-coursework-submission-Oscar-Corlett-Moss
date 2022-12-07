using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flightPath : MonoBehaviour
{
    [ SerializeField ]
    GameObject orbitTarget;

    [ SerializeField ]
    public bool isCrashing = false;

    void FixedUpdate() {
        if (isCrashing == false) {
            transform.RotateAround(orbitTarget.transform.position, Vector3.up, 20 * Time.deltaTime);
        }
    }
}
