using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public PlayerBoard PlayerBoards;
	// Use this for initialization
	void Start () {
    //    StartCoroutine("playCardsSlowly");
	}


    IEnumerator playCardsSlowly() {
        for (int i = 0; i < 5; i++)
        {
            PlayerBoards.PlayCard(i);
            yield return new WaitForSeconds(1);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
