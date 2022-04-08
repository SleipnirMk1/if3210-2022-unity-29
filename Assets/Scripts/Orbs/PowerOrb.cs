using UnityEngine;

public class PowerOr : OrbObject {
    public int damageBonus = 4; 

    protected override void CollectOrb(){
        base.CollectOrb();

        playerShooting = gameObjectCollectingOrb.GetComponent<PlayerShooting>();

        playerShooting.damagePerShot += if (playerShooting.damagePerShot < playerShooting.maxDamage) playerdamageBonus else 0;
    }
}