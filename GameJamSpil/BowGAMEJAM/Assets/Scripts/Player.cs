using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour
{
    
    public ParticleSystem ps;
    // Use this for initialization
    void Start()
    {
        
    }
    float zed;

    public void SetPe(float here) {

        Vector3 he = new Vector3(ps.transform.position.x, here, ps.transform.position.z);
        ps.transform.position = he;
        
        StartCoroutine("Splatter");

    }

    IEnumerator Splatter()
    {
        //Debug.Log("Slatter!");
        yield return new WaitForSeconds(2);
        ps.Play();
        

    }

    IEnumerator SplatterSounds() {
        
        SndController.sndInst.PlayScream(gameObject.tag);
        yield return new WaitForSeconds(1.5f);
        SndController.sndInst.PlaySplat(gameObject.tag);
    }

    IEnumerator EndScene() {
        yield return new WaitForSeconds(5);
        GameController.GmCtrlInst.death = false;

        Application.LoadLevel(1);
    }


    public void GetHit(int i) {
        if (gameObject.tag == "Player" && i ==2 && GameController.GmCtrlInst.death == false)
        {
           // Email.instanceEmail.SendMail();
            BgMusicPlayer.MusInst.pl2Score++;
            SndController.sndInst.PlayHit(gameObject.tag);
            StartCoroutine("SplatterSounds");
            StartCoroutine("EndScene");

            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            CameraAwesom.instance.DeadCam(gameObject);
            GameController.GmCtrlInst.death = true;

        }

        if (gameObject.tag == "Player2" && i == 1 && GameController.GmCtrlInst.death == false)
        {
            //Email.instanceEmail.SendMail();

            BgMusicPlayer.MusInst.pl1Score++;
            SndController.sndInst.PlayHit(gameObject.tag);
            StartCoroutine("SplatterSounds");
            StartCoroutine("EndScene");


            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            CameraAwesom.instance.DeadCam(gameObject);
            GameController.GmCtrlInst.death = true;

        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (gameObject.tag == "Player" && col.gameObject.layer == 9)
        {

            Debug.Log("Playa 1 Daed");
        }
        if (gameObject.tag == "Player2" && col.gameObject.layer == 8)
        {
            Debug.Log("Playa 2 Daed");
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
