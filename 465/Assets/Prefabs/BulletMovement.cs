using UnityEngine;
using System.Collections;
using UnityEngine.Networking; //Need to add for Network behaviours

public class BulletMovement : NetworkBehaviour
{

    // Use this for initialization
    void Start () {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.TransformDirection(Vector3.forward * 100);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log(col.gameObject.tag);
		if (col.gameObject.tag == "Player") {
			Debug.Log ("hit");
			col.gameObject.GetComponent<TankHealth> ().TakeDamage (10);
		}
		Network.Destroy (this.gameObject);
    }
}
