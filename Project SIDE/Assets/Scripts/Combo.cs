using UnityEngine;
using System.Collections;

public interface Combo {

	void doDamage(Enemy enemy, float damage, GameObject player);

	bool isBlocked();


}
