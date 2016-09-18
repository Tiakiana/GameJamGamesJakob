using UnityEngine;
using System.Collections;

public class GoalScr : MonoBehaviour {
    public GameObject ToMe;
	// Use this for initialization
	void Start () {
        StartCoroutine("DestroyMe");

    }

    IEnumerator DestroyMe() {
        yield return new WaitForSeconds(10);
            //ToMe.GetComponent<EnemyAIScr>().target = null;
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
