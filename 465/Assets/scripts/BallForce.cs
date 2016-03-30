using UnityEngine;
using System.Collections;

public class BallForce : MonoBehaviour
{

    public float bounceFactor = 0.9f; // Determines how the ball will be bouncing after landing. The value is [0..1]
    public float forceFactor = 10f;
    public float tMax = 5f; // Pressing time upper limit

    private float kickStart; // Keeps time, when you press button
    public float kickForce; // Keeps time interval between button press and release 
    private Vector3 prevVelocity; // Keeps rigidbody velocity, calculated in FixedUpdate()

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            //GetComponent<Rigidbody>().AddForce(transform.forward * 350);
            float angle = Random.Range(20, 60) * Mathf.Deg2Rad;
            GetComponent<Rigidbody>().AddForce(new Vector3(0.0f,
                                           forceFactor * Mathf.Clamp(kickForce, 0.0f, tMax) * Mathf.Sin(angle),
                                           forceFactor * Mathf.Clamp(kickForce, 0.0f, tMax) * Mathf.Cos(angle)),
                               ForceMode.VelocityChange);
            prevVelocity = GetComponent<Rigidbody>().velocity;
        }
        /*if (col.gameObject.tag == "Ground") // Do not forget assign tag to the field
        {
            GetComponent<Rigidbody>().velocity = new Vector3(prevVelocity.x,
                                             -prevVelocity.y * Mathf.Clamp01(bounceFactor),
                                             prevVelocity.z);
        }*/
    }

}

