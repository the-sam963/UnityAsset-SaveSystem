using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory inventory;

    [Header("Player Data")]
    public int health = 100;
    public int diamond = 0;
    
    void Awake()
    {
        DoNotDestroy();
    }

    private void DoNotDestroy()
    {
        if (inventory == null)
        {
            DontDestroyOnLoad(gameObject);
            inventory = this;
        }
        else if (inventory != this)
        {
            Destroy(gameObject);
        }
    }

    
}
