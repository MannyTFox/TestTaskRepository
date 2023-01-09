using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellPanelScript : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject SellItemTemplate;
    [SerializeField] GameObject shopkeep;
    PlayerInventory inventory;


    private void Update()
    {
       // UpdateSellPanelDisplay();
        
       
    }

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<PlayerInventory>();

       
    }

    public void UpdateSellPanelDisplay()
    {
        // Clear the current buttons
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Create new buttons for each item in the inventory
        foreach (var item in inventory.items)
        {
            GameObject g = Instantiate(SellItemTemplate, transform);
            g.GetComponent<SellItemTemplateScript>().Create(item);
        }
    }

}
