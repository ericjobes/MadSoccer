using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoring : MonoBehaviour
{

    public CarScript player;
    public GameObject ball;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.myScore);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ball")
        {
            player.myScore += 1;
            Vector3 temp = new Vector3(0, 0, 0);
            ball.transform.position = temp;
        }
    }
}
