using UnityEngine;

public class HealthOrb : OrbObject {
    public int healthBonus = 10;
    private PlayerHealth playerHealth;

    protected override void activateOrb(){
        base.activateOrb();
        playerHealth = playerObject.GetComponent<PlayerHealth>();
        playerHealth.currentHealth += playerHealth.currentHealth < playerHealth.startingHealth ? healthBonus : 0;
    }
}