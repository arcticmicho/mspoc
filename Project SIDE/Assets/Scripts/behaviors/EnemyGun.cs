using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
	private FrostBallSkill enemyBallAttack; 
	private int count = 0;
	public float framesToWait;
	public float distGunAttack;
	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		enemyBallAttack = new FrostBallSkill ();
		count = (int) Random.Range (1, framesToWait);
	}

	void Update () {

		if(Mathf.Abs(this.transform.position.x - player.transform.position.x) < distGunAttack){
			count++;
			if(count == framesToWait){
				enemyBallAttack.create (gameObject, "enemy");
				count = (int) Random.Range (1, framesToWait);
			}
		}


	}
	
}
