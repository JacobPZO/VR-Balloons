using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public GameObject balloonPrefab;
    public float floatStrength = 20f;
    private GameObject balloon;

    void FixedUpdate()
    {
        if (Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            CreateBalloon();
            UnityEngine.Debug.Log("DOWN!");
            ReleaseBalloon();
        }
        /*else if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            UnityEngine.Debug.Log("UP!");
            ReleaseBalloon();
        }*/
    }

    public void CreateBalloon()
    {
        balloon = Instantiate(balloonPrefab);
        return;
    }

    public void ReleaseBalloon()
    {
        Rigidbody rb = balloon.GetComponent<Rigidbody>();
        Vector3 force = Vector3.up * floatStrength;
        rb.AddForce(force);

        GameObject.Destroy(balloon, 10f);
        balloon = null;
    }
}
