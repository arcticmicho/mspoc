using UnityEngine;
using System.Collections;

public class MultiBallToolBox : MonoBehaviour {

	private Skill gun;

	void Start () {
		gun = new MultiBallSkill();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Skill getGunOnObject()
	{
		return gun;
	}

	public void destroyObject()
	{
		Destroy(gameObject);
	}
}
