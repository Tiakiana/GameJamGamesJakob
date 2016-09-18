using UnityEngine;
using System.Collections;

public class BowShoot : MonoBehaviour
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

            transform.RotateAround(transform.position, Vector3.forward, flailing * Time.deltaTime);




        if (Input.GetKeyDown("space"))
        {
            var ngo = Instantiate(arro, arrow.transform.position, arrow.transform.rotation) as GameObject;
            ngo.AddComponent<Rigidbody>().AddForce(arrow.transform.right * power, ForceMode.Impulse);
            

                ngo.AddComponent<ArrowScript>().playerSender = 1;
           
            

            


        }
        if (Input.GetKeyDown("space"))
        {
            SndController.sndInst.PlayShoot("Player");

            parent.AddForce(-pivot.transform.right* thrust,ForceMode.Force);
        }



    }

    void FixedUpdate()
    {
        
    }


}


