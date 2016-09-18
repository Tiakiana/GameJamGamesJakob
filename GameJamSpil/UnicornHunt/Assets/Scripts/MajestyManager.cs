using UnityEngine;
using System.Collections;

public class MajestyManager : MonoBehaviour {
    public GameObject Pawn;
    public GameObject Goal;
    public static MajestyManager MajestyInst;

    void Awake() {
        MajestyInst = this;

    }

	void Start () {
	
	}
	
	
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            var v3 = Input.mousePosition;
            v3.z = 10.0f;
            v3 = Camera.main.ScreenToWorldPoint(v3);
            if (Pawn != null)
            {
                //   Debug.Log("Now im here");
                Pawn.GetComponent<EnemyScr>().StartWalkingAnim();
                GameObject go = Instantiate(Goal, transform.position, transform.rotation) as GameObject;
                go.transform.position = v3;
                go.GetComponent<GoalScr>().ToMe = Pawn;
                Pawn.GetComponent<EnemyAIScr>().target = go.transform;
                Pawn = null;

            }

          /*  Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("Clicked");
            if (Physics.Raycast(ray))
            {
                Debug.Log("Firing");
                if (Pawn!= null)
                {
                    Debug.Log("Now im here");

                    GameObject go = Instantiate(Goal, transform.position, transform.rotation) as GameObject;

                    go.GetComponent<GoalScr>().ToMe = Pawn;
                    Pawn.GetComponent<EnemyAIScr>().target = go.transform;
                    Pawn = null;

                }

            }
            */
        }
    }
}
