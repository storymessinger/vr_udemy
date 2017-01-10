using UnityEngine;
using System.Collections;

public class CreateRotation : MonoBehaviour
{
    public GameObject Player;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float rotationSpeed = 3.0f;
	    float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
	    float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
	    transform.rotation *= Quaternion.Euler(0, mouseX, 0);
        Camera camera = GetComponentInChildren<Camera>();
	    camera.transform.localRotation *= Quaternion.Euler(-mouseY, 0, 0);
	}
}
