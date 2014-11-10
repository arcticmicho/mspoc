using UnityEngine;
using System.Collections;

public class Running : MonoBehaviour {
	
	public CharacterController walker;
	public float speedWalk = 10.0F;
	public float speedRun = 25.0F;
	public float runStamina = 30.0f;
	private float runCount;
	public bool canRun;


	void Start () {
		runCount = runStamina;
		canRun = true;
	}
	

	void FixedUpdate () {
		
				
		if (Input.GetKey(KeyCode.Q) && runCount>0 && canRun){
			runCount -= Time.deltaTime;
			if (walker.movSpeed != speedRun){
				walker.setMovSpeed(speedRun);

			}
			if(runCount < 0){
				runCount =0;
				canRun = false;

			}
			
		}else{
			if (walker.movSpeed != speedWalk){
				walker.setMovSpeed(speedWalk);
			}
			if(runCount>runStamina){
				runCount = runStamina;
				canRun = true;
			}else{runCount += Time.deltaTime*3;}
		}
	
	}
}
