using UnityEngine;
using System.Collections;

public class BowShoot2 : MonoBehaviour
{

    public float power = 30;
    public float flailing = 300;
    public GameObject pivot;
    public GameObject arro;
    public Rigidbody parent;
    public float thrust = -10;

    void Start()
    {

    }
    public GameObject arrow;

    void Update()
    {

        transform.RotateAround(transform.position, Vector3.forward, -flailing * Time.deltaTime);




        if (Input.GetKeyDown("up"))
        {
            var ngo = Instantiate(arro, arrow.transform.position, arrow.transform.rotation) as GameObject;
            ngo.AddComponent<Rigidbody>().AddForce(arrow.transform.right * power, ForceMode.Impulse);
            ngo.AddComponent<ArrowScript>().playerSender = 2;


        }
        if (Input.GetKeyDown("up"))
        {
            SndController.sndInst.PlayShoot("Player2");

            parent.AddForce(pivot.transform.right * thrust);
        }



    }

}
