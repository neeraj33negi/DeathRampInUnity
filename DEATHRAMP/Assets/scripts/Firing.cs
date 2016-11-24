using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour {
	public GameObject obj;
	CharacterControl fireControl;

	RaycastHit hit;
	void Start () {
		fireControl = obj.GetComponent<CharacterControl> ();
	}

	void Update () {

	}
	public void shoot(){
		//Vector3 fwd = fireControl.transform.TransformDirection (Vector3.forward);
		Debug.Log (fireControl.transform.position);
	    Debug.DrawRay (fireControl.transform.position,  Vector3.forward, Color.magenta);
		//Physics.Raycast (fireControl.transform.position,  fwd,10,hit);
	}
}
