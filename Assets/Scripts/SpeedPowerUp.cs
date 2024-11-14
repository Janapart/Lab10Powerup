using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : PowerUp
{

     float speedMultiplier = 2.0f;
     float duration = 0.5f;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(speedMultiplier, duration);
    }
}
