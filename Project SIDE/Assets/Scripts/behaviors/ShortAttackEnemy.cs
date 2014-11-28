using UnityEngine;
using System.Collections;

public class ShortAttackEnemy : MonoBehaviour {

	private GameObject enemy;
	private GameObject player;

	void Start () {
		enemy = GameObject.FindGameObjectWithTag("BasicEnemy");
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D player) {
		if(player.gameObject.tag.Equals(Constants.PLAYER_TAG)){
			print("Enemy Attack");
		}
		else{
			print("Not Enemy Attack");
		}
	}
}
