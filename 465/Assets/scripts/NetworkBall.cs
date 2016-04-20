using UnityEngine;
using UnityEngine.Networking;

public class NetworkBall : NetworkBehaviour {

	[SyncVar]
	Color myColor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MeshRenderer renderer = GetComponent<MeshRenderer> ();
		//Debug.Log (myColor);
		renderer.material.color = myColor;
	}

	public void SetColor(Color newColor) {
		Debug.Log ("SC: " + newColor);
		myColor = newColor;
	}
}
