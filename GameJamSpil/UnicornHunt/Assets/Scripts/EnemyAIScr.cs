using UnityEngine;
using System.Collections;

public class EnemyAIScr : MonoBehaviour {
    public Transform target;
    public GameObject Unicorn;
	// Use this for initialization
	void Start () {
        Unicorn = GameObject.Find("Unicorn");
        target = Unicorn.transform;
	}
    private Vector3 v_diff;
    private float atan2;
    // Update is called once per frame
    void Update () {
        /*
        var dir = Target.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Debug.Log(angle);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        */
        if (target!=null)
        {
            if (Vector2.Distance(gameObject.transform.position, target.position) < 0.5f)
            {
                target = Unicorn.transform;
            }
        }
       
        v_diff = (target.position - transform.position);
        atan2 = Mathf.Atan2(v_diff.y, v_diff.x);
        transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);

    }
}
