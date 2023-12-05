using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuzaiNorth : MonoBehaviour
{
    float north;
    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
        Input.compass.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        north = Input.compass.trueHeading;
        // Smoothly tilts a transform towards a target rotation.
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, -north, 0), Time.deltaTime * 2.0f);
        // transform.rotation = Quaternion.Euler(0, -north, 0);
    }
}
