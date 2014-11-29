using UnityEngine;
using System.Collections;

public class EnemyBallDetection : MonoBehaviour {

	private GameObject player;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D enemyBall) {

		if(enemyBall.gameObject.tag.Equals(Constants.ENEMY_FROSTBALL_TAG)){
			Destroy(player);
		}

	}
}
