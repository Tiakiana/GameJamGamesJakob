using UnityEngine;
using System.Collections;

public class KillzoneScr : MonoBehaviour {
    public bool Deadly;
    public float Damage;
	// Use this for initialization
	void Start () {
	
	}

    public void SetDeadly(bool deadly) {
        Deadly = deadly;
    }
    void OnCollisionEnter2D(Collision2D col) {
  //      Debug.Log("Hit");
        if (Deadly && col.gameObject.tag == "Enemy")
        {

            col.gameObject.GetComponent<EnemyScr>().TakeDamage(Damage);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
