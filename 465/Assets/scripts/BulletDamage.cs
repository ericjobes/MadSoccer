using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<TankHealth>().TakeDamage(10);
        }
        if (col.gameObject.tag == "Boundary")
        {
            Debug.Log("about to die");
            Network.Destroy(gameObject);
        }
    }
}
