using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Networking; //Need to add for Network behaviours

public class NetworkThrow : NetworkBehaviour {

	public GameObject objectToThrow;
	public List<Color> colorList;
    public Transform spawn;

	// Update is called once per frame
	void Update () {

		if (objectToThrow != null) {
			if (Input.GetButtonUp ("Fire1")) {
				CmdShoot ();
			}
		}
	}

	//Calls the function on the server
	[Command]
	void CmdShoot() {
		GameObject obj = Instantiate (objectToThrow, spawn.position, spawn.rotation) as GameObject;
		NetworkServer.Spawn (obj);
		Rigidbody rb = obj.GetComponent<Rigidbody>();

		Color newColor = new Color (Random.value, Random.value, Random.value);
		if (colorList.Count > 0) {
			newColor = colorList [(int)(Random.value * colorList.Count)];
		}

		NetworkBall ballScript = obj.GetComponent<NetworkBall> ();
		ballScript.SetColor (newColor);
        rb.velocity = transform.TransformDirection(Vector3.forward * 1000);
        Destroy(rb.gameObject, 5);
    }
}
