using UnityEngine;
using System.Collections;

public class BasicGun : MonoBehaviour {

	private FrostBallSkill frostBallSkill;
	public GameObject character;
	public CharacterController characterController;
	private bool isShooting;
	// Use this for initialization
	void Start () {
		frostBallSkill = new FrostBallSkill();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.R))
		{
			frostBallSkill.create(character);
			isShooting = true;
			makeShootAnimation();
		}
		else 
		{
			isShooting = false;
			makeIdleAnimation();
		}
	}

	void makeShootAnimation ()
	{
		characterController.Anim.SetBool ("isShooting", true);
	}

	void makeIdleAnimation ()
	{
		characterController.Anim.SetBool ("isShooting", false);
	}
}
