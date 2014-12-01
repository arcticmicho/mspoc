using UnityEngine;
using System.Collections;

public class FrostBall : MonoBehaviour {

	public float movSpeed = 200;
	float damage = 0;
	bool visible = true;

	// Use this for initialization
	void Start () {
		//Just for testing
		//setMovement(100,1);
	}
	
	// Update is called once per frame
	void Update () {

		if(!visible)
		{
			destroyWhenNoVisible();
		}
		Debug.Log(visible);
	}

	public void setMovement(float damage, float direction)
	{
		rigidbody2D.velocity = new Vector2(direction * movSpeed,0);
		this.damage = damage;
	}

	public void setEnemyMovement(float damage, float direction)
	{
		rigidbody2D.velocity = new Vector2(direction * movSpeed/2,0);
		this.damage = damage;
	}

	void OnTriggerEnter2D(Collider2D target){
		print (gameObject.tag + "_______________---------------------------" + Constants.PLAYER_FROSTBALL);
		if(gameObject.tag.Equals (Constants.PLAYER_FROSTBALL) && target.tag.Equals(Constants.BASIC_ENEMY_TAG))
		{
			Enemy enemy = target.GetComponent<Enemy>();
			enemy.restHP(damage);
			//TODO Add child effect to enemy (Movemment speed reduced)
			//TODO add animation of impact;
			Destroy(gameObject);

		}else
		{
			if(!target.tag.Equals(Constants.PLAYER_TAG)&& !target.tag.Equals(Constants.ATTACK_RANGE_TAG))
			{
				//Destroy (gameObject);
			}	
		}
	}

	void OnBecameInvisible () {
		visible = false;
	}

	void destroyWhenNoVisible ()
	{
		Destroy(gameObject);
	}
}
