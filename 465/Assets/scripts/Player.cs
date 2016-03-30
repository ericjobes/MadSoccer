using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int myScore;
    public float health;

    public GameObject gun;
    public shoot barrel;

    // Use this for initialization
    void Start () {
        myScore = 0;
        health = 0f;
	}
	
	// Update is called once per frame
	void Update () {
	
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
