﻿using UnityEngine;
using System.Collections;

public class enemyDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "enemy"){
			Destroy (col.gameObject);
		}
	}
}
