using UnityEngine;
using System.Collections;

public class BasicAI : Enemy {
	
	private GameObject player;
	public float enemySpeed = 4.0f;
	private bool isNear;
	// Use this for initialization
	void Start () {
		
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
		
//		if (!isNear) {
//			Vector2 start = transform.position;
//			Vector2 end = Vector2.MoveTowards(start, (Vector2) player.transform.position, enemySpeed * Time.deltaTime);
//			transform.position = end;
//			
//		}else{
//			
//		}
	
	}
	
	void OnTriggerEnter(Collider target){
		
		if(target.transform.tag.Equals("Player")){
			isNear = true;	
		}
	}
	
	void OnTriggerExit(Collider target){
		if(target.transform.tag.Equals("Player")){
			isNear = false;	
		}
	}
}
