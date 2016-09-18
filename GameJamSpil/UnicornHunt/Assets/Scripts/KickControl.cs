using UnityEngine;
using System.Collections;

public class KickControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyScr>().TakeDamage(10);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
