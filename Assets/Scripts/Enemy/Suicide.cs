using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicide : MonoBehaviour
{
    EnemyHealth enemyHealth;
    GameObject player;

    public float timeToDie = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        enemyHealth = GetComponent<EnemyHealth>();  
    }

    void OnTriggerEnter (Collider other)
    {
        //Set player dalam range
        if(other.gameObject == player && other.isTrigger == false)
        {
            StartCoroutine("WaitCoroutine");
            
        }
    }

    IEnumerator WaitCoroutine()
    {
        //yield on a new YieldInstruction that waits for seconds.
        yield return new WaitForSeconds(timeToDie);
        enemyHealth.TakeDamage(enemyHealth.currentHealth, transform.position);
    }
}
