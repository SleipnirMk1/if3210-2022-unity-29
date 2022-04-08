using UnityEngine;

public class OrbObject : MonoBehaviour {
    // Orb Info 
    public string orbName;
    public string orbExplanation;

    protected enum State{ 
        Standby,
        Collected,
        Expired
    }

    protected State state;


    protected virtual void Start() {
        state = State.Standby;
    }

    // Collision detector
    protected void OnTriggerEnter (Collider3D collision) {
        CollectOrb(collision.gameObject)
    }

    // Check collected orb;
    protected virtual void CollectOrb(GameObject gameObjectCollectingOrb){
        if(gameObjectCollectingOrb.tag != "Player"){ return; }

        if(state == State.Standby || state = State.Expired ) { return; }

        state = State.Collected;
    }


    protected virtual void DestroySelf(){
        Destroy(gameObject, 10f);
    }



    
}