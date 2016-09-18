using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class GameController : MonoBehaviour {
    public static GameController GmCtrlInst;
    public bool death= false;
    public int pl1Score = 0;
    public int pl2Score = 0;

    void Awake() {
        GmCtrlInst = this;
        //DontDestroyOnLoad(this);
    }

  
    // Use this for initialization
    void Start () {
    
        SetLayers();


    }

    

    public void SetLayers() {
        Physics.IgnoreLayerCollision(8, 9, true);
        Physics.IgnoreLayerCollision(9, 8, true);
        Physics.IgnoreLayerCollision(8, 14, true);
        Physics.IgnoreLayerCollision(9, 15, true);

        //set for spiller 1
        List<int> layers = new List<int>();
        layers.Add(10);
        layers.Add(11);
        layers.Add(12);
        layers.Add(13);

        int rnd = Random.Range(0, 2);

        for (int i = rnd; i >-1 ; i--)
        {
            int rn = Random.Range(0, layers.Count);
            Physics.IgnoreLayerCollision(8, layers[rn], true);
            
            Debug.Log("Archer can safely ignore " + layers[rn]);
            layers.RemoveAt(rn);
        }

        


// set layers for spiller2
        List<int> layers2 = new List<int>();
        layers2.Add(10);
        layers2.Add(11);
        layers2.Add(12);
        layers2.Add(13);


        for (int i = rnd; i > -1; i--)
        {
            int rn = Random.Range(0, layers2.Count);
            Physics.IgnoreLayerCollision(9, layers2[rn], true);
            layers2.RemoveAt(rn);
        }
        Debug.Log("Player ignores Default layer == "+ Physics.GetIgnoreLayerCollision(0, 14));
    }
    
    void Update () {
      
	}
}
