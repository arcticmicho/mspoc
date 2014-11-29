using UnityEngine;
using System.Collections;

public class BasicGun : MonoBehaviour {

	private FrostBallSkill frostBallSkill;
	private MultiBallSkill multiBallSkill;
	private Skill currentGun;
	public GameObject character;
	public CharacterController characterController;
	private bool isShooting;
	// Use this for initialization
	void Start () {
		frostBallSkill = new FrostBallSkill();
		multiBallSkill = new MultiBallSkill();
		currentGun = frostBallSkill;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKeyUp(KeyCode.R))
		{
			currentGun.create(character);
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

	public void changeGun(Skill newGun)
	{
		currentGun = newGun;
	}
}
