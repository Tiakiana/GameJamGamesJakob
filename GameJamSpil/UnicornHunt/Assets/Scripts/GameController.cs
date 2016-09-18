using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;

public class GameController : MonoBehaviour {
    public static GameController GameCtrlInst;
    public GameObject resspawn;
    public List<GameObject> Spawners = new List<GameObject>();
    public float SpawnTime = 10f;
    public float Timer = 300f;
    public Text TimerTxt;
    float spawntime;
    void Awake() {

        GameCtrlInst = this;
        Physics2D.IgnoreLayerCollision(8,8,true);
    }

    public void GoToMaidenWin() {
        EditorSceneManager.LoadScene(1);
    }

    public void GoToMajestyWin() {
        EditorSceneManager.LoadScene(2);


    }

    public void SpawnDude() {
        int j = Random.Range(0, 3);
        Spawners[j].GetComponent<SpawnerScr>().SpawnDude();
    }

    public void SpawnRes() {
        resspawn.GetComponent<ResourceSpawner>().SpawnRes();
    }
    void Start() {
        spawntime = SpawnTime;

    }
    void Update() {
        spawntime -= Time.deltaTime;
        if (spawntime<0)
        {
            spawntime = SpawnTime;
            SpawnRes();
        }
        Timer -= Time.deltaTime;
        if (Timer<= 0)
        {
            GoToMaidenWin();
        }
        TimerTxt.text = Timer.ToString();

        if (Input.GetKeyUp("o"))
        {
            EditorSceneManager.LoadScene(0);
        }


    }
}
