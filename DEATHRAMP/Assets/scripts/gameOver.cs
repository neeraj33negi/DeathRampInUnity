using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameOver : MonoBehaviour {
	public int userscore=0;
	//int hscore = 0;
	public void playGame(string game){
		Application.LoadLevel (game);
		PlayerPrefs.SetInt ("UserScore",userscore);
	}
	public void exitGame(){
		Application.Quit ();
	}
}
