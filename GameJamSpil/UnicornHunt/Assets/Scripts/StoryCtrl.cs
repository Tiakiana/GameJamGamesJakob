using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StoryCtrl : MonoBehaviour {
    int slide = 0;

    public GameObject spr;
    public Sprite newspr;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            if (slide == 0)
            {
                spr.GetComponent<SpriteRenderer>().sprite = newspr;
                slide++;


            }
            else
            {
                SceneManager.LoadScene(0);

            }
        }
	}
}
