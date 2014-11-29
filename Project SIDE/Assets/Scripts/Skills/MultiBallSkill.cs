using UnityEngine;
using System.Collections;

public class MultiBallSkill : Skill  {

	GameObject multiBallSkill;
	int ballDamage = 50;
	float frostballDamage = Constants.FROSTBALL_DAMAGE;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region implemented abstract members of Skill

	public override void lunchSkill ()
	{
		throw new System.NotImplementedException ();
	}

	public override void restSoul ()
	{
		throw new System.NotImplementedException ();
	}

	public override void setCooldown ()
	{
		throw new System.NotImplementedException ();
	}

	public override void create (GameObject character)
	{
		createVerticalBall (character);
		createDownHorizontalBall (character);
		createUpperHorizontalBall (character);
	}
	
	#endregion

	void createVerticalBall (GameObject character)
	{
		multiBallSkill = GameObject.Instantiate (Resources.Load (Constants.PATH_TO_MULTIBALL)) as GameObject;
		multiBallSkill.transform.position = character.transform.localPosition;
		MultiBall multiBallObject = multiBallSkill.GetComponent<MultiBall> ();
		CharacterController characterController = character.GetComponent<CharacterController>();
		multiBallObject.setMovement (ballDamage, characterController.isFacingRight () ? 1 : -1, 0);
	}

	void createDownHorizontalBall (GameObject character)
	{
		multiBallSkill = GameObject.Instantiate (Resources.Load (Constants.PATH_TO_MULTIBALL)) as GameObject;
		multiBallSkill.transform.position = character.transform.localPosition;
		MultiBall multiBallObject = multiBallSkill.GetComponent<MultiBall> ();
		CharacterController characterController = character.GetComponent<CharacterController>();
		multiBallObject.setMovement (ballDamage, characterController.isFacingRight () ? 1 : -1, -1);
	}

	void createUpperHorizontalBall (GameObject character)
	{
		multiBallSkill = GameObject.Instantiate (Resources.Load (Constants.PATH_TO_MULTIBALL)) as GameObject;
		multiBallSkill.transform.position = character.transform.localPosition;
		MultiBall multiBallObject = multiBallSkill.GetComponent<MultiBall> ();
		CharacterController characterController = character.GetComponent<CharacterController>();
		multiBallObject.setMovement (ballDamage, characterController.isFacingRight () ? 1 : -1, 1);
	}
}
