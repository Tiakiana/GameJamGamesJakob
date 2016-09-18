using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.layer = Random.Range(10, 14);    
	}

    void OnCollisionEnter(Collision col) {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Arrow(Clone)"|| col.gameObject.name == "Arrow2(Clone)")
        {
            gameObject.AddComponent<Rigidbody>().AddForceAtPosition(-Vector3.forward*15,col.transform.position , ForceMode.Impulse);

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
