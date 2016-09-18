using UnityEngine;
using System.Collections;

public class PickUpScr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter2D(Collision2D col) {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Enemy")
        {
            SoundCtrl.SoundCtrlInst.PlayMoreMen();
            GameController.GameCtrlInst.SpawnDude();
            Destroy(gameObject);

        }
        if (col.gameObject.tag == "Player")
        {
            SoundCtrl.SoundCtrlInst.PlayNo();

            col.gameObject.GetComponent<UnicornCtrl>().Heal();
            Destroy(gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
