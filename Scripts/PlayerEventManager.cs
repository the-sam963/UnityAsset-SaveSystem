using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerEventManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI diamondText;


    void Update()
    {
        UpdateUIElements();
    }

    void UpdateUIElements()
    {
        healthText.text ="Health : " + Inventory.inventory.health.ToString();
        diamondText.text = "Diamond : " + Inventory.inventory.diamond.ToString();
    }
}
