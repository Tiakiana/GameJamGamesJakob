using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour {
    public Vector3 velocity;
    public Vector3 pos;
    public Rigidbody rb;
    public int playerSender;
    
	// Use this for initialization
	void Start () {
        pos = transform.position;
        rb = GetComponent<Rigidbody>();


    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Player2")
        {
            col.gameObject.SendMessage("GetHit", playerSender);

            col.gameObject.SendMessage("SetPe", gameObject.transform.position.y);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        else {
            DestroyObject(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
       /* var localVelocity = transform.InverseTransformDirection(rb.velocity);
        var theDirection = Quaternion.Inverse(gameObject.transform.rotation) * localVelocity;
        transform.position = theDirection;
    */
    }
}
