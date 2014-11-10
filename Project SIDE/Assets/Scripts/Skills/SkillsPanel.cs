using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillsPanel : MonoBehaviour {

	public GameObject character;
	List<Skill> skills = new List<Skill>();
	int skillSelected = 0;

	// Use this for initialization
	void Start () {
		skills.Add(new FrostBallSkill());	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.R))
		{
			skills[skillSelected].create(character);
		}
		if(Input.GetKeyUp(KeyCode.Alpha1))
		{
			skillSelected = 0;
			//TODO Set anim on the skill
		}else if(Input.GetKeyUp(KeyCode.Alpha2))
		{
			skillSelected = 1;
			//TODO Set anim on the skill
		}else if(Input.GetKeyUp(KeyCode.Alpha3))
		{
			skillSelected = 2;
			//TODO Set anim on the skill
		}else if(Input.GetKeyUp(KeyCode.Alpha4))
		{
			skillSelected = 3;
			//TODO Set anim on the skill
		}
	}
}
