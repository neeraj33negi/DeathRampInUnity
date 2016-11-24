using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class finalScore : MonoBehaviour {
	public Text ufinalScore;
	public Text highScore;
	int fscore;
	int highestScore;
	void Start () {
		highestScore = PlayerPrefs.GetInt ("HighScore");
		highScore.text = highestScore.ToString ();
		fscore = PlayerPrefs.GetInt ("UserScore");
		if(PlayerPrefs.GetInt("UserScore")>PlayerPrefs.GetInt("HighScore")){
			highScore.text = fscore.ToString();
			PlayerPrefs.SetInt("HighScore",fscore);
		}
		ufinalScore.text = fscore.ToString ();
		PlayerPrefs.SetInt ("UserScore",0);
	}

}
