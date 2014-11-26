using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float movSpeed = 10f;
	bool facingRight = false;
	public Animator anim;
	public LayerMask whatIsGround;
	public float jumpForce = 100f;
	public Transform pointA;
	public Transform pointB;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate()
	{
		float direction = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(direction * movSpeed,rigidbody2D.velocity.y);
		anim.SetFloat("Speed",Mathf.Abs(direction));
		

		
		if(direction>0 && !facingRight)
			Flip();
		else
			if(direction<0 && facingRight)
				Flip();
	}
	// Update is called once per frame
	void Update () {
		bool isGroundedVar = isGrounded();
		if(Input.GetKeyDown(KeyCode.Space) && isGroundedVar )
		{
			Jump();
		}
	}

	private void Flip()
	{
		Vector3  newScale = transform.localScale;
		newScale.x *= -1;
		facingRight = !facingRight;
		transform.localScale = newScale;

	}

	private bool isGrounded()
	{
		bool grounded = Physics2D.OverlapArea(pointA.position,pointB.position,whatIsGround);
		Debug.Log ("is: "+grounded);
		anim.SetBool("Grounded",grounded);
		return grounded;
	}

	private void Jump()
	{
		rigidbody2D.AddForce(new Vector2(0,jumpForce));
	}

	public void setMovSpeed(float movSpeed)
	{
		this.movSpeed = movSpeed;
	}

	public bool isFacingRight()
	{
		return facingRight;
	}

}
