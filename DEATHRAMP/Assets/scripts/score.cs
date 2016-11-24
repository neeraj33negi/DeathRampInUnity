using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public GameObject obj;
	CharacterControl controller;
	public Text scoreText;
	float scoreRate =0.5f;
	public float scorereal=0f;
	void Start () {
		controller = obj.GetComponent<CharacterControl> ();
		scoreText.text = (PlayerPrefs.GetInt("UserScore")).ToString();

	}
	
	// Update is called once per frame
	void Update () {

	}
	void FixedUpdate(){
		if (controller.flagForCollision != 1) {
			getScore ();
		}
	}
	void getScore(){

		scorereal += scoreRate;
		scoreText.text = ((int)scorereal).ToString();
		PlayerPrefs.SetInt ("UserScore",(int)scorereal);
		//Debug.Log (scorereal);
	}
}
