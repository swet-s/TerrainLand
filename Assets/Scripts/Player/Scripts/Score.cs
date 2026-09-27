using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public bool keyboard()
	{
	if (Input.GetKey("w")||Input.GetKey("up")||Input.GetKey("s")||Input.GetKey("down")||Input.GetKey("j"))
	return true;
	else 
	return false;
	}
    public Text score;
	public Transform player;
	public Transform target;
	float points = 0;
    void Update()
    {	
		if (keyboard())
		points += 1;
		//		Mathf.Abs(player.position.z)*Mathf.Abs(player.position.x) ;
        score.text =  points.ToString("0");
    }
}
