using UnityEngine;
using System.Collections;

public class MediumCombo : Combo {


	bool blocked;

	public void doDamage(Enemy enemy, float damage, GameObject player){
		enemy.restHP(damage);
	}
	
	public bool isBlocked(){
		return blocked;
	}

	public void setBlocked(bool blocked)
	{
		this.blocked = blocked;
	}


}
