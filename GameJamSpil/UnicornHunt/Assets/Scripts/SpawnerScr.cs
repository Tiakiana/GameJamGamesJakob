using UnityEngine;
using System.Collections;

public class SpawnerScr : MonoBehaviour {

    public GameObject SpawnObject;
    float rateOfSpawn = 0.5f; //spawn every 0.5 seconds
    private float nextSpawn = 0;

    public void SpawnDude() {
        var spawnBox = transform.localScale;
        var position = new Vector3(Random.value * spawnBox.x, Random.value * spawnBox.x, Random.value * spawnBox.x);
        position = transform.TransformPoint(position - spawnBox / 2);
        var obj = Instantiate(SpawnObject, position, transform.rotation);

    }


    void Update()
    {
       
    }
}
