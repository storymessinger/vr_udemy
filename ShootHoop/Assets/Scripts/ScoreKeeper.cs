using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{
    private int hitCount = 0; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // internal method for collision
    public void IncrementScore(int amount)
    {
        hitCount += amount;
        print("Your current score is: " + hitCount);
    }
}
