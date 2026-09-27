using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallCollision : MonoBehaviour
{
	public int lastlevel = 1;
    void OnCollisionEnter (Collision col){
		if (col.gameObject.name == "Healthy Ball")
			{
			Debug.Log("you win");
			//if ( SceneManager.GetActiveScene().buildIndex != lastlevel-1)
			//	{
			//	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			//	}
			//else 
			//	Debug.Log("No more level found");
			}
		}
}