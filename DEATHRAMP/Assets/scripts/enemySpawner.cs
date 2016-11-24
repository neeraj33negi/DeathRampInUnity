using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {

	public GameObject enemy;
	public float minPosX=-1.85f;
	public float maxPosX=1.85f;
	public Vector3 enemyPos;
	public float delayTimer = 1f;
	public float timer;
	void Start () {
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0f) {
			enemyPos = new Vector3 (Random.Range (minPosX, maxPosX), transform.position.y, transform.position.z);
			Instantiate (enemy, enemyPos, transform.rotation);
			timer = delayTimer;
		}

	}

}
