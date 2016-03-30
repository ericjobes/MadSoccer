using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour
{

    public Player player;
    public GameObject ball;

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
        if (col.gameObject.name == "Ball")
        {
            player.myScore += 1;
            Vector3 temp = new Vector3(0, 0, 0);
            ball.transform.position = temp;
            Debug.Log(player.myScore);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            player.transform.position = new Vector3(0, 0, -14);
            player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}