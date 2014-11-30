using UnityEngine;
using System.Collections;

public class BallDetection : MonoBehaviour {
	private int count;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		count = 30;
	}
	
	// Update is called once per frame
	void Update () {
		if(count > 0){
			count--;
		}
	}

	void OnTriggerEnter2D(Collider2D ball) {
		if(ball.gameObject.tag.Equals(Constants.FROSTBALL_TAG) && Mathf.Abs(ball.transform.position.y - enemy.transform.position.y) < 1 ){
			if(count == 0){
				enemy.rigidbody2D.AddForce(new Vector2(0,1000 ));
				print("Jump Skipt");
				count = 30;
			}

		}
		else{
			print("Jump Not Skipt");
		}
	}
}
