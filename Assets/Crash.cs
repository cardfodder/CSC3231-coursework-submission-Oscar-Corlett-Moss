using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    [ SerializeField ]
    GameObject UFOObject;

    [ SerializeField ]
    GameObject spotlight;

    [ SerializeField ]
    GameObject tractorBeam;

    [ SerializeField ]
    GameObject dustFloor;

    [ SerializeField ]
    GameObject chassis;

    [ SerializeField ]
    GameObject bottom;

    [ SerializeField ]
    GameObject explosive;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C)){
            tractorBeam.GetComponent<ParticleSystem>().Stop();
            dustFloor.GetComponent<ParticleSystem>().Stop();
            explosive.GetComponent<ParticleSystem>().Play();
            UFOObject.GetComponent<flightPath>().isCrashing = true;
            chassis.GetComponent<Rigidbody>().useGravity = true;
            bottom.GetComponent<Rigidbody>().useGravity = true;
            chassis.GetComponent<Rigidbody>().velocity = new Vector3(10,0,0);
            spotlight.GetComponent<Light>().intensity = 0;
            
        }
    }
}
