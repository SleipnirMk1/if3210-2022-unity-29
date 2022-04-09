using UnityEngine;

public class SpawnOrb : MonoBehaviour {
    public GameObject orbPrefab;
    public float spawnTime = 3f;
    private float currentTimeToSpawn = 1f; 
    void Start() {

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
        Instantiate(orbPrefab, transform.position, transform.rotation);
    }

    // IEnumerator orbSpawn(){
    //     while(true){
    //         yield return new WaitForSeconds(spawnTime);
    //         spawn();
    //     }
    // }
    
}