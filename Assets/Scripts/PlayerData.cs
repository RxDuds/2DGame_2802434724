using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public int extrajumps;
    public int healthkits;
    public int health;
    public int coins;

    public PlayerData (Player player)
    {
        extrajumps = player.extraJumpValue;
        health = player.health;
        healthkits = player.healthkit;
        coins = player.coins;
    }
}
