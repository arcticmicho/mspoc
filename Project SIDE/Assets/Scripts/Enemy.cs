using UnityEngine;
using System.Collections;

public abstract class Enemy : MonoBehaviour {
	
	public float healthPoints = 100;
	public float def = 5;
	public string enemyName = "Default";
	
	public void restHP(float damage){
		//TODO add damage reduction by armor
		healthPoints -= damage;	
	}
	
	public bool checkIfDead(){
		if (healthPoints <= 0)
			return true;
		return false;
	}
	
}
