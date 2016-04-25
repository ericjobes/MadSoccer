using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int myScore;
	public float health;
	private float distanceToGround;
	public GameObject gun;
	public NetworkThrow barrel;

	// Use this for initialization
	void Start () {
		myScore = 0;
		health = 0f;
	}
	bool IsGrounded() {
		return Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump"))
		{
			if(IsGrounded())
				GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.VelocityChange);
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "PowerUp")
		{
			gun.SetActive(true);
			barrel.enabled = true;
			col.gameObject.SetActive(false);
		}
	}
}
