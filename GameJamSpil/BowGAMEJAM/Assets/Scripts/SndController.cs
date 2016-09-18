using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;

public class SndController : MonoBehaviour {
    public static SndController sndInst;
    public List<AudioClip> sounds = new List<AudioClip>();
    void Awake() {
        sndInst = this;
    }

    public void PlayShoot(string go) {
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().clip = sounds[0];
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().Play();

    }
    public void PlaySplat(string go)
    {
    
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().clip = sounds[2];
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().Play();

    }

    public void PlayScream(string go)
    {
        
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().clip = sounds[3];
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().Play();

    }
    public void PlayHit(string go)
    {
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().clip = sounds[1];
        GameObject.FindGameObjectWithTag(go).GetComponent<AudioSource>().Play();

    }
    void Start () {
	
	}
	
	void Update () {
	
	}
}
