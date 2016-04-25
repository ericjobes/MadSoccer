using UnityEngine;
using System.Collections;

public class TeamColor : MonoBehaviour {

	public Material newMaterialRef1;
	public Material newMaterialRef2;

	// Use this for initialization
	void Start () {
		if (GetComponent<Transform>().position.z > 0)
		{
			Debug.Log("Coloring");
			GetComponent<Renderer>().material = newMaterialRef1;
		}
		else
		{
			GetComponent<Renderer>().material = newMaterialRef2;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
