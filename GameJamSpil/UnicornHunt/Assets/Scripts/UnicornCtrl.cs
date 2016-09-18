using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class UnicornCtrl : MonoBehaviour {



    
    public string frem;
    public string tilbage;
    public string venstre;
    public string hojre;
    public string skyd;
    public string spark;
    public float hastighed;
    public float acceleration;
    public float drejeHastighed;
    public float draen;
    public float maxHastighed;
    public float genladningstid = 3;
    public float genladningstidSpark = 2;
    public float Health;
    public Slider Healthbar;
    float reload = 0;
    float reloadSpark = 0; 
    public bool Player1;
    AudioSource ass;
    public GameObject skud;
    public GameObject KillZoneFront;
    public Transform barrel;
    public bool Immune = false;
    public GameObject Kicker;
    Rigidbody2D r2d;
    public Sprite Kickersprite, NormalSprite;
    Animator anim;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        r2d = GetComponent<Rigidbody2D>();
        r2d.gravityScale = 0;
        StartCoroutine("Controls");
        ass = GetComponent<AudioSource>();
        Healthbar.maxValue = Health;
        Healthbar.value = Health;
      //  StartCoroutine("Animations");
    }



    

    //der mangler  point og menu og genstart.

    public void TakeDamage(float dam)
    {

        if (!Immune)
        {
            SoundCtrl.SoundCtrlInst.PlayStab();
            Health -= dam;
            Healthbar.value = Health;
            if (Health <= 0)
            {
                Destroy(gameObject);
                GameController.GameCtrlInst.GoToMajestyWin();
            }
        }
        
    }
    public void Heal() {
        Health = Healthbar.maxValue;
        Healthbar.value = Health;
    }

    public IEnumerator Controls()
    {
      //  Debug.Log("startingCotroutaældskgfjnaø");
        while (true)
        {
            if (Input.GetKeyUp(spark) && reloadSpark <= 0)
            {
                SoundCtrl.SoundCtrlInst.PlayAKick();
                reloadSpark = genladningstidSpark;
                StartCoroutine("Kick");
            }

            if (Input.GetKey(venstre))
            {
             //   Debug.Log("fremad!");
                transform.RotateAround(transform.position, Vector3.forward, drejeHastighed * Time.deltaTime);

            }

            if (Input.GetKey(hojre))
            {
                transform.RotateAround(transform.position, Vector3.forward, -drejeHastighed * Time.deltaTime);
            }

            if (Input.GetKey(frem) && hastighed < maxHastighed)
            {
                hastighed += acceleration / 100;
            }


            if (Input.GetKey(tilbage) && hastighed > -maxHastighed)
            {
                hastighed -= acceleration / 100;
            }


            transform.position += transform.right * hastighed * Time.deltaTime;

            if (hastighed >= 0.01f)
            {
                hastighed -= draen / 100;
            }
            if (hastighed <= 0.01f)
            {
                hastighed += draen / 100;
            }

            if (Input.GetKeyDown(skyd) && reload <= 0)
            {
                SoundCtrl.SoundCtrlInst.PlayANeigh();
                Skyd();
            }
           

            yield return new WaitForSeconds(0.0001f);
        }

    }

    public GameObject Trail;
    public IEnumerator Charge() {
        anim.SetTrigger("Charge");
        GameObject go = Instantiate(Trail,transform.position,Quaternion.identity) as GameObject;
        go.transform.SetParent(gameObject.transform);
        go.transform.localPosition = new Vector3(-0.7900001f, 0f, -2.14f);


        float gammelDrejehastighed = drejeHastighed;
        Immune = true;
        float gammelMax = maxHastighed;
        drejeHastighed = drejeHastighed / 2;
        maxHastighed = maxHastighed * 2;
        hastighed = hastighed * 2;
        KillZoneFront.GetComponent<KillzoneScr>().SetDeadly(true);

        yield return new WaitForSeconds(0.5f);
        go.transform.SetParent(null);

        yield return new WaitForSeconds(1);

        KillZoneFront.GetComponent<KillzoneScr>().SetDeadly(false);

        maxHastighed = gammelMax;
        drejeHastighed = gammelDrejehastighed;
        hastighed = 1;  
        Immune = false;
    }

    IEnumerator Kick() {
        Immune = true;
        //gameObject.GetComponent<SpriteRenderer>().sprite = Kickersprite;
        Kicker.gameObject.SetActive(true);
        anim.SetBool("Kick", true);
        yield return new WaitForSeconds(0.3f);
        Kicker.gameObject.SetActive(false);
        Immune = false;
        //gameObject.GetComponent<SpriteRenderer>().sprite = NormalSprite;
        anim.SetBool("Kick", false);

    }

    void Skyd()
    {
        reload = genladningstid;
        
        // Instantiate(skud, barrel.position, barrel.rotation);
        StartCoroutine("Charge");
        ScreenShake.ScreenShakeInst.Shake();

      //  SoundController.sndInstance.PlaySound1(SoundController.sndInstance.audioClips1[0]);
    }
    bool running = false;
    // Update is called once per frame
    void Update()
    {
     //   ass.pitch = hastighed;
        if (reload > 0)
        {
            reload -= Time.deltaTime;
        }
        if (reloadSpark >0)
        {
            reloadSpark -= Time.deltaTime;
        }
        anim.SetFloat("Running", hastighed);




    }
}


