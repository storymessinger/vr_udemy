using UnityEngine;
using System.Collections;

public class BallLauncher: MonoBehaviour {

    // make GameObject to get the link to the basketball prefab
    public GameObject ballPrefab;
    public float ballSpeed = 30.0f;
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
	    launchBall("Fire1");
	}
    
    // launch basketball
    void launchBall(string kc) 
    { 
        if(Input.GetButtonDown(kc)) {
            // make instance of ballPrefab
            GameObject instance = Instantiate(ballPrefab);
            // put the instance just behind the main camera
            instance.transform.position = transform.position;
            // match the 'forward' direction of the main camera and the instance
            Quaternion up30 = Quaternion.Euler(-15, 0, 0); // make the basketball go upward angle a little
            Camera camera = GetComponentInChildren<Camera>();
            Vector3 direction = camera.transform.rotation * up30 * Vector3.forward;
            // give instance an rigidbody component
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            // give instance the direction and the speed on making (shoot)
            rb.velocity = direction * ballSpeed;
        }
    }
}
