using UnityEngine;
using System.Collections;

public class powerupSpawner : MonoBehaviour {

	score scoreRef;
	float speed = 25f;
	public GameObject refToScript;
	public GameObject powerUp;
	public float minPosX=-1.85f;
	public float maxPosX=1.85f;
	public Vector3 powerUpPos;
	public float delayTimer = 1f;
	public float timer;
	int scoreCount;
	void Start () {

	}

	void FixedUpdate () {
		scoreRef = refToScript.GetComponent<score>();
		scoreCount = (int)scoreRef.scorereal;
		Debug.Log (scoreCount);
		if((scoreCount>0) && (scoreCount%100==0)){
			powerUpPos = new Vector3(Random.Range(minPosX,maxPosX),transform.position.y,transform.position.z);
			Instantiate(powerUp,powerUpPos,transform.rotation);
		}
	}
}
