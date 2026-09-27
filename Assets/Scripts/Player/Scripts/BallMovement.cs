using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BallMovement : MonoBehaviour
{
	public Rigidbody rb;
	public Transform player;
	public Transform camera;
	public Vector3 offset;
	public float forwardforce = 00f;
	
	
    // Update is called once per frame
    void FixedUpdate()
    {
	float angle = camera.rotation.eulerAngles.y*Mathf.Deg2Rad;
	float forceSide = 0f;     
	float forceFront = 0f;    
	float force = forwardforce*Time.deltaTime;
	
	//if (Input.GetKey("w")||Input.GetKey("up")){
		forceFront = force*Mathf.Cos(angle);
		forceSide = force*Mathf.Sin(angle);
	//}
	//if (Input.GetKey("s")||Input.GetKey("down")){
		//forceFront = -force*Mathf.Cos(angle);
		//forceSide = -force*Mathf.Sin(angle);
	//}
	
	
	if (Input.GetKey("j")){
		rb.AddForce(0,force,0);
		forceFront = force*Mathf.Cos(angle);
		forceSide = force*Mathf.Sin(angle);
	}
        rb.AddForce(forceSide,0,forceFront);
    }

	
}