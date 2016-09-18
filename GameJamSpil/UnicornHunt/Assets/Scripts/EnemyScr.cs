using UnityEngine;
using System.Collections;

public class EnemyScr : MonoBehaviour {
    public float Health;
    public float hastighed;
    public float attack;
    public GameObject Death;
    // Use this for initialization
    Animator anim;
       
	void Start () {
        StartCoroutine("Walks");
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(float dam) {
        Health -= dam;
        if (Health<= 0)
        {
            GameController.GameCtrlInst.SpawnDude();
            GameObject go = Instantiate(Death, gameObject.transform.position,Quaternion.EulerAngles(transform.rotation.x, transform.rotation.y, transform.rotation.z)) as GameObject;
            SoundCtrl.SoundCtrlInst.PlayADeath();
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Player" && col.gameObject.name != "KillZoneKick")
        {
            col.gameObject.GetComponent<UnicornCtrl>().TakeDamage(attack);
        }

    }
    IEnumerator Walks() {
        while (true)
        {

            transform.position += transform.right * hastighed * Time.deltaTime;
            yield return new WaitForSeconds(0.0001f);


        }

    }
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseUp() {
        ImClicked();
    }

    public void StartWalkingAnim() {
        anim.SetBool("Selected", false);


    }

    public void ImClicked()
    {
        anim.SetBool("Selected", true);
        MajestyManager.MajestyInst.Pawn = gameObject;
        
    }

}
