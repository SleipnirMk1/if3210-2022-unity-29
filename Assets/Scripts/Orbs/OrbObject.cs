using UnityEngine;

public class OrbObject : MonoBehaviour {
    // Orb Info 
    public string orbName;
    public string orbExplanation;

    // public PlayerMovement playerMovement;
    protected GameObject playerObject;

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
    protected void OnTriggerEnter (Collider collision) {
        CollectOrb(collision.gameObject);
        DestroySelf();
    }

    // Check collected orb;
    protected virtual void CollectOrb(GameObject gameObjectCollectingOrb){
        if( gameObjectCollectingOrb.tag != "Player" ){ 
            return; 
        }

        if( state == State.Standby || state == State.Expired ) { 
            return; 
        }

        state = State.Collected;
        playerObject = gameObjectCollectingOrb; 
        activateOrb();
        
    }

    protected virtual void activateOrb(){
        // DestroySelf();
    }


    protected virtual void DestroySelf(){
        Destroy(gameObject, 10f);
    }



    
};