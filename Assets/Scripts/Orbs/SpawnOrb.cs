using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnOrb : MonoBehaviour {

    [SerializeField]
    public GameObject[] orbsPrefab;

    public float spawnTime = 3f;
    private float currentTimeToSpawn = 1f; 
    private Bounds backdrop;
    


    void Start() {
        backdrop = GameObject.Find("Planks").GetComponent<Renderer>().bounds;
        // screeBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // StartCourutine(orbSpawn());
    }

    void Update(){
        if(currentTimeToSpawn > 0 ){
            currentTimeToSpawn -= Time.deltaTime;
        } else {
            spawn();
            currentTimeToSpawn = spawnTime; 
        }

    }

    private void spawn(){
        // Random rnd = new Random();
        float y = 0.5f;
        float x = Random.Range(backdrop.center.x+15,backdrop.center.z-15);
        float z = Random.Range(backdrop.center.z+15,backdrop.center.z-15);
        Instantiate(orbsPrefab[Random.Range(0, orbsPrefab.Length)], new Vector3(x, y, z), transform.rotation);
        // Debug.Log(string.Format("Pogchamp {0} {1} {2}", x, y, z));
        
    }

    // IEnumerator orbSpawn(){
    //     while(true){
    //         yield return new WaitForSeconds(spawnTime);
    //         spawn();
    //     }
    // }
    
}