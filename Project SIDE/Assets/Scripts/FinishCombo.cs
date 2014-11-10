using UnityEngine;
using System.Collections;

public class FinishCombo : Combo {

	private float pushForce = 500f;

	public void doDamage (Enemy enemy, float damage, GameObject player)
	{
		enemy.restHP(damage);
		Vector2 forceDirection = ((Vector2)((enemy.transform.localPosition - player.transform.localPosition)));
		forceDirection = new Vector2(forceDirection.x/Mathf.Abs(forceDirection.x),0);
		Debug.Log(forceDirection);
		enemy.rigidbody2D.AddForce(forceDirection * pushForce);
	}

	public bool isBlocked ()
	{
		throw new System.NotImplementedException ();
	}
}
