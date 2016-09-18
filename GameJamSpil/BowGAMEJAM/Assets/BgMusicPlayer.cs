using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BgMusicPlayer : MonoBehaviour {
    public Text[] scores = new Text[2];
    
    public int pl1Score = 0;
    public int pl2Score = 0;
    public static BgMusicPlayer MusInst;

    void UpdateScore()
    {
        scores[0].text = "" + pl1Score;
        scores[1].text = "" + pl2Score;
        if (pl1Score >= 5) {
            Application.LoadLevel(2);
        }
        if (pl2Score >= 5)
        {
            Application.LoadLevel(3);
        }

    }
    // Use this for initialization
    void Awake () {
        MusInst = this;
        DontDestroyOnLoad(this.gameObject);


    }
    public void StartGame() {
        Application.LoadLevel(1);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
        UpdateScore();
	}
}
