using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour
{

    public Player player;
    public GameObject ball;
	public int goalScore;
	public GameObject explosion;

    // Use this for initialization
    void Start()
    {
		goalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
			goalScore += 1;
			Instantiate (explosion, this.transform.position, Quaternion.identity);
            Vector3 temp = new Vector3(0, 0, 0);
            ball.transform.position = temp;
            Debug.Log(goalScore);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

			//instead of transforming player, respawn?
            player.transform.position = new Vector3(0, 0, -14);
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}