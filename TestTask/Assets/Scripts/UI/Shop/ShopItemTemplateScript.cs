using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemTemplateScript : MonoBehaviour
{

    public Item item;
    public bool outOfStock;

    Item itemStored;

    public int itemAmmount;

    [SerializeField] Image itemImageDisplay;
    [SerializeField] TextMeshProUGUI itemNameDisplay;
    [SerializeField] TextMeshProUGUI itemPriceDisplay;


    private void Update()
    {

        if(itemAmmount <= 0)
        {
            outOfStock = true;
        }
        
        if(outOfStock)
        {
            OutOfStock();
        }
        else
        {
            Create(itemStored); //If ammount somehow increases, only reason itemStoredExists
        }
      
    }

    public void Create(Item _item)
    {
        item = _item;
        itemStored = item;

        itemImageDisplay.sprite = item.itemImage;
        itemNameDisplay.text = item.itemName;
        itemPriceDisplay.text = item.itemPrice.ToString() + "g";
        itemAmmount = 1;

    }

    public void Buy()
    {
        //get a reference to the player
        GameObject player = GameObject.FindGameObjectWithTag("Player"); ;

        //first we check if the item is not out of stock
        if (!outOfStock)
        {
            //get a reference to the player's inventory
            var inventory = player.GetComponent<PlayerInventory>();

            //if the player has enough gold
            if (inventory.gold >= item.itemPrice)
            {
                //buy the item
                player.GetComponent<PlayerInventory>().gold -= item.itemPrice;              
                player.GetComponent<PlayerInventory>().items.Add(item);
                player.GetComponent<PlayerInventory>().ListHasChanged();
                itemAmmount -= 1;
            }

        }

    }

    public void OutOfStock()
    {
        itemImageDisplay.sprite = item.itemImage;
        itemNameDisplay.text = "out of stock!";
        itemPriceDisplay.text = "";
    }

}
