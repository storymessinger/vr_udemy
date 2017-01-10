using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour
{

    public int scorePerHit = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        // Getting the Object directly, not the GameObject
        ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper>();
        // use the method in that Object
        scorekeeper.IncrementScore(scorePerHit);
    }
}
