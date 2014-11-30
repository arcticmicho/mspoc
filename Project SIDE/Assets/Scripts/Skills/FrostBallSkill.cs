using UnityEngine;
using System.Collections;

public class FrostBallSkill : Skill {

	GameObject frostballSkill;
	int ballDamage = 50;
	float frostballDamage = Constants.FROSTBALL_DAMAGE;

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

		frostballSkill = GameObject.Instantiate(Resources.Load(Constants.PATH_TO_FROSTBALL)) as GameObject;
		frostballSkill.transform.position = character.transform.localPosition;
		FrostBall frostBallObject = frostballSkill.GetComponent<FrostBall>();
		CharacterController characterController = character.GetComponent<CharacterController>();
		frostBallObject.setMovement(ballDamage,characterController.isFacingRight() ? 1:-1);
	}

	public void create (GameObject character, string enemy)
	{
		frostballSkill = GameObject.Instantiate(Resources.Load(Constants.PATH_TO_ENEMY_FROSTBALL)) as GameObject;
		frostballSkill.transform.position = character.transform.localPosition;
		FrostBall frostBallObject = frostballSkill.GetComponent<FrostBall>();
		BasicAI enemyController = character.GetComponent<BasicAI>();
		frostBallObject.setEnemyMovement(ballDamage, enemyController.isPlayerInRight() ? 1:-1);
	}
	
	#endregion
}
