using UnityEngine;
using System.Collections;

public class BasicAI : Enemy {
	
	private GameObject player;
	public float enemySpeed;
	public float distNearAttack;
	public bool nearAttack;
	private bool isNear;

	private bool facingRight = false;

	// Use this for initialization
	void Start () {
		isNear = false; 
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update(){ 
		if(healthPoints <= 0){
			Destroy(gameObject);	
		}
		if(facingRight && isPlayerInLeft()){
			flip ();
			print("Flip left");
		}
		else if(!facingRight && isPlayerInRight()){
			flip ();
			print("Flip right");
		}
	}

	public bool isPlayerInLeft(){
		return player.transform.position.x <= this.transform.position.x;
	}

	public bool isPlayerInRight(){
		return player.transform.position.x > this.transform.position.x;
	}
	
	// Update is called once per frame
	void FixedUpdate () {



		if (nearAttack) {
			Vector2 start = transform.position;
			Vector2 posPlayer = player.transform.position;

			if(Mathf.Abs(start.x - posPlayer.x) < distNearAttack){
				print ("Near attack");
				Vector2 end = Vector2.MoveTowards(start, (Vector2) player.transform.position, enemySpeed * Time.deltaTime);
				transform.position = end;
				if(facingRight){
					rigidbody2D.velocity = new Vector2(enemySpeed * 2, rigidbody2D.velocity.y);
				}
				else{
					rigidbody2D.velocity = new Vector2(-enemySpeed * 2, rigidbody2D.velocity.y);
				}


			}

		}
	
	}

	private void flip()
	{
		Vector3  newScale = transform.localScale;
		newScale.x *= -1;
		facingRight = !facingRight;
		transform.localScale = newScale;
		
	}
	
	void OnTriggerEnter(Collider target){
		
		if(target.transform.tag.Equals("Player")){
			isNear = true;	
		}
	}

	public bool doRandomMovement1to1000Probability(int probability){
		float randomNumber = Random.Range (1, 1000);
		if(randomNumber <= probability){
			return true;
		}
		return false;
	}
	
	void OnTriggerExit(Collider target){
		if(target.transform.tag.Equals("Player")){
			isNear = false;	
		}
	}
}
