using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundCtrl : MonoBehaviour {
    public static SoundCtrl SoundCtrlInst;
    public List<AudioClip> Clips = new List<AudioClip>();
    public List<AudioClip> HorseClips = new List<AudioClip>();
    public List<AudioClip> KingClips = new List<AudioClip>();
    public List<AudioSource> Speakers = new List<AudioSource>();
    
    public AudioSource HorseSnd;
    public AudioSource KingSnd;
    int speakercount = 0;

    void Awake() {
        SoundCtrlInst = this;

    }

	void Start () {
	
	}
    public void PlayADeath(){
        if (speakercount<2)
        {
            speakercount++;
            
        }
        else
        {
            speakercount = 0;
        }
        Speakers[speakercount].clip = Clips[Random.Range(0, 3)];
        Speakers[speakercount].Play();
    }
    public void PlayAKick() {
        HorseSnd.clip = HorseClips[0];
        HorseSnd.Play();
    }

    public void PlayANeigh()
    {
        HorseSnd.clip = HorseClips[1];
        HorseSnd.Play();
    }
    public void PlayMoreMen()
    {
        KingSnd.clip = KingClips[Random.Range(0,2)];
        KingSnd.Play();
    }
    public void PlayNo() {
        KingSnd.clip = KingClips[Random.Range(2, 4)];
        KingSnd.Play();

    }
    public void PlayStab() {
        if (speakercount < 2)
        {
            speakercount++;

        }
        else
        {
            speakercount = 0;
        }
        Speakers[speakercount].clip = Clips[3];
        Speakers[speakercount].Play();

    }
    // Update is called once per frame
    void Update () {
	
	}
}
