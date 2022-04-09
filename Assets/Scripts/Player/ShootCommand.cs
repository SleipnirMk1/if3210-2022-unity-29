using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCommand : Command
{

    PlayerShooting playerShooting;

    public ShootCommand(PlayerShooting _playerShooting)
    {
        playerShooting = _playerShooting;
    }

    public override void Execute()
    {
        int angle = 0;
        //Player menembak
        for( int i = 0; i < playerShooting.diagonalBullets+1; i++) {
                playerShooting.Shoot(angle*i);
        }
        
        
    }

    public override void UnExecute()
    {
        
    }
}