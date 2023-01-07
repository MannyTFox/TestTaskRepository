using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ShopContainer : MonoBehaviour
{
    public Item item;
    public bool outOfStock;


    public int itemAmmount;

    [SerializeField]Image itemImageDisplay;
    [SerializeField]TextMeshProUGUI itemNameDisplay;
    [SerializeField]TextMeshProUGUI itemPriceDisplay;
    [SerializeField]TextMeshProUGUI itemAmmountDisplay;


    public void Buy()
    {
        //get a reference to the player
        GameObject player = GameObject.FindGameObjectWithTag("Player");  ;
        
        //first we check if the item is not out of stock
        if(!outOfStock)
        {     
            //get a reference to the player's inventory
            var inventory = player.GetComponent<PlayerInventory>();

           //if the player has enough gold
            if(inventory.gold >= item.itemPrice)
            {           
                //buy the item
                player.GetComponent<PlayerInventory>().gold -= item.itemPrice;
                itemAmmount -= 1;
                player.GetComponent<PlayerInventory>().items.Add(item);
                player.GetComponent<PlayerInventory>().ListHasChanged();
            }

        }
        
    }

    private void Awake()
    {
        //set image name and price to the scriptable object this containter represents

        itemImageDisplay.sprite = item.itemImage;
        itemNameDisplay.text = item.itemName;
        itemPriceDisplay.text = item.itemPrice.ToString() + "g";
        
            
    }



    void Update()
    {

        //Update item ammount display, and check if out of stock, could be done using events for optimization

        itemAmmountDisplay.text = "(" + itemAmmount.ToString() + ")";

        if (itemAmmount <= 0)
        {
            outOfStock = true;
        }
        else
        {
            outOfStock = false;
        }
    }
}
