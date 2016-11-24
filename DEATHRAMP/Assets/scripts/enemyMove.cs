using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour {
	public float speed = 30f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(0,0,-1)* speed * Time.deltaTime);
	}
}
