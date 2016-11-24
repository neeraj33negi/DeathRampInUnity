using UnityEngine;
using System.Collections;

public class RampMove : MonoBehaviour {

	public float speed;
	public Vector2 offset;
	//input variables
	public float forwardInput=6f;
	public float inputDelay = 0.1f;

	void Start () {
		speed = 5f;
		forwardInput = 0f;

	}
	
	// Update is called once per frame
	void Update () {
		getInput ();
	}
	void FixedUpdate(){
		run ();
		offset = new Vector2 (0,-Time.time*speed);
		Renderer textureRenderer = GetComponent<Renderer>();
		textureRenderer.material.mainTextureOffset = offset;
	}

	void getInput(){
		forwardInput = Input.GetAxis ("Vertical");
	}
	void run(){
		if(Mathf.Abs(forwardInput)>inputDelay){
			offset = new Vector2 (0,Time.time*speed*(-forwardInput));
			Renderer textureRenderer = GetComponent<Renderer>();
			textureRenderer.material.mainTextureOffset = offset;
		}
	}
}
