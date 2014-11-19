using UnityEngine;
using System.Collections;

public class BasicAI : Enemy {
	
	private GameObject player;
	public float enemySpeed = 4.0f;
	public float distNearAttack = 5f;
	private bool nearAttackWithJump;
	private bool nearAttack;
	private bool isNear;
	public bool closerMoviment;
	public bool skipBall;
	public float jumpForce = 400;
	// Use this for initialization
	void Start () {
		nearAttackWithJump = false;
		nearAttack = false;
		skipBall = true;
		closerMoviment = true;
		isNear = false; 
		player = GameObject.FindGameObjectWithTag("Player");

	
	}
	
	void Update(){
		if(healthPoints <= 0){
			Destroy(gameObject);	
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (closerMoviment) {
			Vector2 start = transform.position;
			Vector2 end = Vector2.MoveTowards(start, (Vector2) player.transform.position, enemySpeed * Time.deltaTime);
			transform.position = end;

		}
		if(skipBall){
			//FrostBall ball  = GameObject.FindObjectOfType(FrostBall.Instantiate);
			//GameObject ball = GameObject.FindGameObjectWithTag("frostBall");
			//rigidbody2D.AddForce(new Vector2(0,jumpForce));
			//print("messagggge");
		}
		if (nearAttack) {
			Vector2 start = transform.position;
			Vector2 posPlayer = player.transform.position;
			if(Mathf.Abs(start.x - posPlayer.x) < distNearAttack){

				if(nearAttackWithJump && doRandomMovement1to1000Probability(20)){
					//rigidbody2D.AddForce(new Vector2(0,jumpForce));
					//print("Jump");
				}
				else{
					//Vector2 end = Vector2.MoveTowards(start, (Vector2) player.transform.position, enemySpeed * Time.deltaTime);
					//transform.position = end;
					//rigidbody2D.velocity = new Vector2(-enemySpeed * 2, rigidbody2D.velocity.y);
				}

			}
		}
	
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
