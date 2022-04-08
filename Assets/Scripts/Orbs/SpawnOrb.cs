using UnityEngine;

public class SpawnOrb : MonoBehaviour {
    public GameObject orbPrefab;
    public float spawnTime = 3.0f;
    void Start() {
        screeBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCourutine(orbSpawn());
    }

    private void spawn(){
        GameObject orb = Instantiate(orbPrefab) as GameObject;
        // a.transform.position = new Vector3(Screen.width, Screen.height);
    }

    IEnumerator orbSpawn(){
        while(true){
            yield return new WaitForSeconds(spawnTime);
            spawn();
        }
    }
    
}