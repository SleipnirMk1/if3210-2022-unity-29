using UnityEngine;

public class EnemyManager : MonoBehaviour{
    public PlayerHealth playerHealth;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    public bool isZen = true;
    public TextAsset enemyWaveText;
    public float waveSpawnInterval = 1f;


    // RELATED FOR WAVE LEVEL
    int currentWaveIdx;
    int currentEnemyIdx;
    EnemyWaveFormat[] enemyWaveFormat;
    GameObject[] currentEnemyList;
    // END RELATED

    [SerializeField]
    MonoBehaviour factory;
    IFactory Factory { get { return factory as IFactory; } }

    void Start(){
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        if (isZen)
        {
            InvokeRepeating("SpawnRandom", spawnTime, spawnTime);
            return;
        }

        ReadEnemyWaveJson(enemyWaveText);
        currentWaveIdx = 0;
    }

    void Update() 
    {
        if (isZen) return;

        int remainingEnemy = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (remainingEnemy <= 0)
        {
            SpawnWave();
        }
    }

    void SpawnRandom(){
        //Jika player telah mati maka tidak membuat enemy baru
        if (playerHealth.currentHealth <= 0f){
           return;
        }

        //Mendapatkan nilai random
       int spawnPointIndex = Random.Range(0, spawnPoints.Length);
       int spawnEnemy = Random.Range(0, 3);

        //Memduplikasi enemy
        GameObject enemy = Factory.FactoryMethod(spawnEnemy);
        enemy.GetComponent<Transform>().Translate(spawnPoints[spawnPointIndex].position);
    }

    void SpawnWave()
    {
        currentEnemyIdx =0;
        EnemyWaveFormat currentWave = enemyWaveFormat[currentWaveIdx];
        currentEnemyList = Factory.RandomMassFactoryMethod(currentWave.waveWeight, currentWave.enemyIdxList);

        // foreach(GameObject enemy in currentEnemyList)
        for (int i=0; i<currentEnemyList.Length; i++)
        {
            Debug.Log("HELLO");
            // currentEnemyList[i].GetComponent<Transform>().Translate(spawnPoints[0].position);
            currentEnemyList[i].SetActive(false);
            if (i==0)
            {
                SpawnWaveEnemy();
            } else 
            {
                Invoke("SpawnWaveEnemy", waveSpawnInterval*i);
            }
        }

        currentWaveIdx = (currentWaveIdx + 1) % enemyWaveFormat.Length;
    }

    void SpawnWaveEnemy() 
    {
        GameObject enemy = currentEnemyList[currentEnemyIdx];
        enemy.GetComponent<Transform>().Translate(spawnPoints[0].position);
        enemy.SetActive(true);
        
        Debug.Log(currentEnemyIdx);

        currentEnemyIdx = (currentEnemyIdx + 1) % currentEnemyList.Length;
    }

    void ReadEnemyWaveJson (TextAsset asset)
    {
        WaveFormatList waveFormatList = JsonUtility.FromJson<WaveFormatList>(asset.text);
        enemyWaveFormat = waveFormatList.waveFormatList;
    }


    [System.Serializable]
    class WaveFormatList
    {
        public EnemyWaveFormat[] waveFormatList;
    }
}
