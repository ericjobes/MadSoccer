using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public float score;
    public Scoring goal1;
    public Scoring goal2;
    public Text countText1;
    public Text countText2;


	// Use this for initialization
	void Start () {
        SetCountText();
	}
	
	// Update is called once per frame
	void Update () {
        SetCountText();
	}

    void SetCountText()
    {	
        countText1.text = "Blue Team: " + goal1.goalScore.ToString();
        countText2.text = "Red Team: " + goal2.goalScore.ToString();
    }

}
