using UnityEngine;
using System.Collections;

public class BasicGun : MonoBehaviour {

	private FrostBallSkill frostBallSkill;
	private MultiBallSkill multiBallSkill;
	private Skill currentGun;
	public GameObject character;
	public CharacterController characterController;
	private bool isShooting;

	public double cooldDown = 0.2;
	private double instantCoolDown;
	// Use this for initialization
	void Start () {
		frostBallSkill = new FrostBallSkill();
		multiBallSkill = new MultiBallSkill();
		currentGun = frostBallSkill;
		instantCoolDown = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.R))
		{
			if(instantCoolDown <= 0)
			{
				currentGun.create(character);
				isShooting = true;
				makeShootAnimation();
				instantCoolDown = cooldDown;
			}else{
				instantCoolDown = instantCoolDown - Time.fixedDeltaTime;
				Debug.Log (instantCoolDown);
				Debug.Log (Time.fixedDeltaTime);
			}
		}
		else 
		{
			instantCoolDown = 0;
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
