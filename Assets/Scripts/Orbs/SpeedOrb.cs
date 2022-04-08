using UnityEngine;

public class SpeedOrb : OrbObject {
    public int speedBonus = 1f;

    protected override void CollectOrb(){
        base.CollectOrb();

        playerMovement = gameObjectCollectingOrb.GetComponent<PlayerMovement>();

        playerMovement.speed += if ( playerMovement.speed < playerMovement.maxSpeed ) speedBonus else 0;
    }
}