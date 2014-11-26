using UnityEngine;
using System.Collections;

public class BallDetection : MonoBehaviour {

	GameObject enemy;
	// Use this for initialization
	void Start () {
		enemy = GameObject.FindGameObjectWithTag("BasicEnemy");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D ball) {
		if(ball.gameObject.tag.Equals(Constants.FROSTBALL_TAG)){
			enemy.rigidbody2D.AddForce(new Vector2(0,1000 ));
			print("Jump Skipt");
		}
		else{
			print("Jump Not Skipt");
		}
	}
}
