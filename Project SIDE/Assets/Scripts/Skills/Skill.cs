using UnityEngine;
using System.Collections;

public abstract class Skill : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public abstract void lunchSkill();

	public abstract void restSoul();

	public abstract void setCooldown();

	public abstract void create(GameObject character);
}