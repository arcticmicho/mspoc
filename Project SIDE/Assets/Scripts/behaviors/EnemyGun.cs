using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
	private FrostBallSkill enemyBallAttack; 
	private int count = 0;

	void Start () {
		enemyBallAttack = new FrostBallSkill ();

	}

	void Update () {
		count++;
		if(count == 100){
			enemyBallAttack.create (gameObject, "enemy");
			count = 0;
		}

	}
	
}
