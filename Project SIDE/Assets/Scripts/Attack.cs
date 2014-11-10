using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Attack : MonoBehaviour {

	// Use this for initialization
	public float cooldownAttack = 0.5f;
	float cooldownAttackCount = 0;
	public float cooldownBtwnCombos = 1.2f;
	float cooldownBtwnCombosCount = 0;
	int comboPosition = 0;
	float combosSize;
	List<GameObject> enemies = new List<GameObject>();
	List<Combo> combos = new List<Combo>();

	// The damage 
	public float damage = 50;

	void Start () {

		combos.Add (new MediumCombo());
		combos.Add (new MediumCombo());
		combos.Add (new MediumCombo());
		combos.Add (new FinishCombo());
		combosSize = combos.Count;

	}
	
	// Update is called once per frame
	void Update () {

		float deltaTime = Time.fixedDeltaTime;
		restOrResetComboCooldown(deltaTime);
		restOrResetAttackCooldown(deltaTime);

		if(Input.GetKeyUp(KeyCode.W)){
			if(cooldownAttackCount == 0){
				Debug.Log("Attack");
				AttackEnemies();
			}
		}

	}
	
	void OnTriggerEnter2D(Collider2D target){

		if (target.transform.tag.Equals("BasicEnemy")){
			if(!enemies.Contains(target.gameObject))
			{
				enemies.Add(target.gameObject);
			}
		}
			
	}
	
	void OnTriggerExit2D(Collider2D target){
		if (target.transform.tag.Equals("BasicEnemy")){
			enemies.Remove(target.gameObject);
			Debug.Log("Salio enemigo Enemigo");
		}
	}
	
	void AttackEnemies(){
		
		foreach(GameObject enemy in enemies.ToArray()){

			Enemy enemyScript = enemy.GetComponent<Enemy>();
			setComboAnimationAndHit();
			combos[comboPosition].doDamage(enemyScript,damage, this.gameObject);
			setCooldownOnCombo();
			ComboText.setComboText(comboPosition.ToString());
			if (enemyScript.checkIfDead())
				enemies.Remove(enemy);
		}
		setCooldownsOnAttack();
	}

	void restOrResetComboCooldown (float deltaTime)
	{
		if(cooldownBtwnCombosCount > 0)
		{
			cooldownBtwnCombosCount = cooldownBtwnCombosCount - deltaTime;		
		}else{
			cooldownBtwnCombosCount = 0;
		}
	}

	void restOrResetAttackCooldown (float deltaTime)
	{
		if (cooldownAttackCount > 0) {
			cooldownAttackCount = cooldownAttackCount - deltaTime;
		}
		if (cooldownAttackCount < 0) {
			cooldownAttackCount = 0;
		}
	}

	void setComboAnimationAndHit ()
	{
		if(cooldownBtwnCombosCount <= 0 || comboPosition == combosSize-1)
		{
			comboPosition = 0;		
		}else
		{
			comboPosition++;
			//TODO Set animation of the combo
		}

	}

	void setCooldownsOnAttack ()
	{
		cooldownAttackCount = cooldownAttack;
	}

	void setCooldownOnCombo ()
	{
		cooldownBtwnCombosCount = cooldownBtwnCombos;
	}
}
