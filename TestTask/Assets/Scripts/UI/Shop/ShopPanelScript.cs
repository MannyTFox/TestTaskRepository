using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopPanelScript : MonoBehaviour
{

    GameObject player;
    [SerializeField] GameObject buttonTemplate;
    [SerializeField]GameObject shopkeep;
    [SerializeField] TextMeshProUGUI goldDisplay;
    ShopkeepInventory inventory;

    
    void Start()
    {
        inventory = shopkeep.GetComponent<ShopkeepInventory>();
        player = GameObject.FindGameObjectWithTag("Player");

        UpdateShopkeepInventoryDisplay();
    }

    private void Update()
    {
        
        goldDisplay.text = player.GetComponent<PlayerInventory>().gold.ToString();
    }

    public void UpdateShopkeepInventoryDisplay()
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
            g.GetComponent<ShopItemTemplateScript>().Create(item);
        }
    }

}
