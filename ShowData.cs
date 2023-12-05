using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowData : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    float angularVelocity;
    float acceleration;
    string result;
    float gravity = 9.81f;
    float altitude;
    float latitude;
    float longitude;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        textMesh.text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
            Input.location.Start();
            Input.gyro.enabled = true;
            // Input.compass.enabled = true;
            altitude = Input.location.lastData.altitude;
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;
            acceleration = Input.acceleration.magnitude;
            angularVelocity = Input.gyro.rotationRate.magnitude;
            result = "Altitude: " + altitude + "\n" + "Latitude: " + latitude + "\n" + "Longitude: " + longitude + "\n" + "Acceleration: " + acceleration + "\n" + "Angular Velocity: " + angularVelocity + "\n" + "Gravity: " + gravity;
            updateText(result);
            result = "";
    }

    void updateText(string newText) {
        textMesh.text = newText;    
    }
}
