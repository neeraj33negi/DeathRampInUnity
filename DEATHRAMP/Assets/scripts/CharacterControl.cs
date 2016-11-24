using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
	Vector3 position;	
	public float inputDelay = 0.1f;
	public float turnInput;
	public float jumpInput;
	public float accelInput;
	public float turnSpeed = 8f;
	Rigidbody rBody;
	public int flagForCollision = 0;
	//jump variables
	Vector3 velocity = Vector3.zero;
	public float downAccel = 0.8f;
	public float jumpVel = 0.3f;
	public LayerMask ramp;
	public RaycastHit hit;
	public float distToRamp = 0.1f;
	//limit position variables
	public float minPosX=-1.85f;
	public float maxPosX=1.85f;
	void Start () {
		if (GetComponent<Rigidbody> ()) {
			rBody = GetComponent<Rigidbody> ();
		} else {
			Debug.LogError("RigidBody Missing");
		}
		position = transform.position;
	}

	void Update () {
		getInput ();
		turn ();

	}
	void FixedUpdate(){
		if (isGrounded ()) {
			Debug.Log("Grounded");
		}
	//	Jump ();
		rBody.velocity = transform.TransformDirection (velocity);
	}
	void getInput(){
		turnInput = Input.GetAxis ("Horizontal");
		jumpInput = Input.GetAxisRaw ("Jump");
		accelInput = Input.acceleration.x;
	}
	void turn(){
		if(Mathf.Abs(turnInput)>inputDelay){
			position.x += (turnInput*Time.deltaTime*turnSpeed);
			position.x = Mathf.Clamp(position.x,minPosX,maxPosX);
			transform.position = position;
		}
		if(Mathf.Abs(accelInput)>inputDelay){
			position.x += (accelInput*Time.deltaTime*turnSpeed);
			position.x = Mathf.Clamp(position.x,minPosX,maxPosX);
			transform.position = position;
		}
	}
	void Jump(){
		if (jumpInput > 0&& isGrounded()) {
			Debug.Log("1");
			velocity.y = jumpVel;
		} else if (jumpInput == 0 && isGrounded()){
			Debug.Log("2");
			velocity.y = 0;
		} else {
			Debug.Log("3");
			//velocity.y -= downAccel;
		}
	}
	public bool isGrounded(){
		Debug.DrawRay (transform.position, Vector3.down,Color.green);
		return (Physics.Raycast (transform.position, Vector3.down, out hit, distToRamp, ramp));

	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "enemy"){
			Application.LoadLevel("gameover");
			flagForCollision =1;
		}
	}
}






























