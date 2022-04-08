using UnityEngine;

public class HealthOrb : OrbObject {
    public int healthBonus = 10;

    protected override void CollectOrb(){
        base.CollectOrb();

        playerHealth = gameObjectCollectingOrb.GetComponent<PlayerHealth>();

        playerHealth.currentHealth += healthBonus;
    }
}