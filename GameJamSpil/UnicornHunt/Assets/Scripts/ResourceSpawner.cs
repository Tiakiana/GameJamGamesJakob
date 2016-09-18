using UnityEngine;
using System.Collections;

public class ResourceSpawner : MonoBehaviour {
    public GameObject SpawnObject;
    // Use this for initialization
    void Start () {
	
	}
    public void SpawnRes()
    {
        var spawnBox = transform.localScale;
        var position = new Vector3(Random.value * spawnBox.x, Random.value * spawnBox.x, Random.value * spawnBox.x);
        position = transform.TransformPoint(position - spawnBox / 2);
        var obj = Instantiate(SpawnObject, position, transform.rotation);
         

}
    // Update is called once per frame
    void Update () {
	}
}
