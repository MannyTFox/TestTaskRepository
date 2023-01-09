using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryPanelScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI goldDisplay; 
    [SerializeField] GameObject buttonTemplate;
    GameObject player;
    PlayerInventory inventory;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        inventory = player.GetComponent<PlayerInventory>();

        //Update once on start
        UpdateInventoryDisplay();
        
    }


    public void UpdateInventoryDisplay()
    {
        // Clear the current buttons
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Create new buttons for each item in the inventory
        foreach (var item in inventory.items)
        {
            GameObject g = Instantiate(buttonTemplate, transform);
            g.GetComponent<ItemTemplateScript>().Create(item);
        }

       

    }

    

    private void Update()
    {

        goldDisplay.text = player.GetComponent<PlayerInventory>().gold.ToString();
    
    }
}
