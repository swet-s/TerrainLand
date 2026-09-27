using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraRotation : MonoBehaviour
{
	public Transform player;
	public Vector3 offset;
	public Vector3 offset2;  
	public float rotation = 4f;
	Vector3 offset3;
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey("left")){
		offset.y -= rotation;
		}
		if (Input.GetKey("right")){		
		offset.y += rotation;
		}
		offset3.x = Mathf.Sin(offset.y*Mathf.Deg2Rad)*offset2.z;
		offset3.y = offset2.y;
		offset3.z = Mathf.Cos(offset.y*Mathf.Deg2Rad)*offset2.z;
	
          transform.rotation = Quaternion.Euler(offset.x,offset.y,offset.z);
		  transform.position = player.position + offset3;
    }
}