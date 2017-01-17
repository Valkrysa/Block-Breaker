using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D trigger){
		print ("trigger");
		//levelManager.LoadLevel("Win");
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		print ("collision");
	}
	
}
