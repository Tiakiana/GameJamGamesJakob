using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SoundController : MonoBehaviour
{
    //public AudioSource audsource;
    public static SoundController sndInstance;
    int player1;
    int player2;
    // int levels = 1;
    // skyd, Død, Obstacle,
    public AudioClip crntClip;
    public List<AudioClip> audioClips1 = new List<AudioClip>();
    //public List<AudioClip> audioClips2 = new List<AudioClip>();
    public AudioSource audios1;
    //public AudioSource audios2;
    //Points pts;
    public Text txt1;
    public Text txt2;

    public bool PlayNewMusic;

    //public MusicController mscctrl;

    public AudioClip Music;

    void Awake()
    {
        sndInstance = this;
        //   DontDestroyOnLoad(this);
        if (GameObject.FindGameObjectsWithTag("Points").Length < 1)
        {
            GameObject ngo = new GameObject();
            ngo.tag = "Points";
       //     ngo.AddComponent<Points>();
            ngo.name = "Points";
        }


    }



    public IEnumerator EndLevel()
    {

        yield return new WaitForSeconds(1);
        int ja = Random.Range(1, 3);
        Debug.Log(ja);
        if (ja == 1)
        {
            Application.LoadLevel("Scene1");

        }
        if (ja == 2)
        {
            Application.LoadLevel("Scene3");

        }

    }
    void Start()
    {
        //  GetComponent<cameraShake>().Shake();

     /*   //Lav en instans af MusicController, hvis ikke der er én i forvejen
        mscctrl = GameObject.FindGameObjectWithTag("MusicController").GetComponent<MusicController>();
        if (mscctrl == null)
        {
            GameObject musicController = new GameObject();
            musicController.AddComponent<MusicController>();
            mscctrl = musicController.GetComponent<MusicController>();


        }
        if (PlayNewMusic)
        {
            mscctrl.PlayMusic(Music);

        }


        pts = GameObject.FindGameObjectWithTag("Points").GetComponent<Points>();

        if (pts.Player1 >= 5)
        {
            Application.LoadLevel("WinscreenGreen");
            pts.Player2 = 0;
            pts.Player1 = 0;

        }
        if (pts.Player2 >= 5)
        {
            Application.LoadLevel("WinscreenRed");
            pts.Player2 = 0;
            pts.Player1 = 0;
        }
        txt1.text = "player 1 score: " + pts.Player1;
        txt2.text = "Player 2 score: " + pts.Player2;
        */
    }
    
    public void PlaySound1(AudioClip au)
    {

        audios1.clip = au;
        audios1.Play();


    }
    /*
    public void PlaySound2(AudioClip au)
    {
        audios2.clip = au;
        audios2.Play();
        
    }
    */
    void Update()
    {
        // Debug.Log(Random.Range(1,3));
    }

}
