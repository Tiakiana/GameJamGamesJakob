using UnityEngine;
using System.Collections;

public class CameraAwesom : MonoBehaviour
{
    public static CameraAwesom instance;
  //  public Vector3 stert;


    public GameObject dedo;
    private Vector3 pos;

    void Awake()
    {
        instance = this;
       
    }

    void Start() {
            }
    public void DeadCam(GameObject go) {
        dedo = go;
        GetComponent<Camera>().orthographic = false;
        StartCoroutine("GetDead");
    }

    public IEnumerator GetDead() {
        
        pos = new Vector3(dedo.transform.position.x, dedo.transform.position.y, dedo.transform.position.z - 3);
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 2f);
            yield return null;
        }
    }

    

    void Update() {
       
    }

}