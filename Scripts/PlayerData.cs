using UnityEngine;
using System;

[Serializable]
public class PlayerData 
{

    public int health;
    public int diamond;

    public PlayerData()
    {
        health = Inventory.inventory.health;
        diamond = Inventory.inventory.diamond;
    }

}
