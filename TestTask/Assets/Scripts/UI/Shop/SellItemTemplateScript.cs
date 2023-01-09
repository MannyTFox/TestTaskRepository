using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellItemTemplateScript : MonoBehaviour
{
    public Item item;
 
    Item itemStored;

    public int itemAmmount;

    [SerializeField] Image itemImageDisplay;
    [SerializeField] TextMeshProUGUI itemNameDisplay;
    [SerializeField] TextMeshProUGUI itemPriceDisplay;


    public void Create(Item _item)
    {
        item = _item;
        itemStored = item;

        itemImageDisplay.sprite = item.itemImage;
        itemNameDisplay.text = item.itemName;
        itemPriceDisplay.text = item.itemSellPrice.ToString() + "g";
        itemAmmount = 1;

    }

    public void Sell()
    {

        print("tried to sell");
        //get a reference to the player and shopkeep
        PlayerInventory player = GameObject.FindObjectOfType<PlayerInventory>();
        ShopkeepInventory shopkeep = GameObject.FindObjectOfType<ShopkeepInventory>();




        //sell the item
        player.gold += item.itemSellPrice;
        player.items.Remove(item);
        player.InventoryHasChanged();
        shopkeep.items.Add(item);
        GameObject.FindObjectOfType<ShopPanelScript>().UpdateShopkeepInventoryDisplay();

        Destroy(gameObject);

      

    }


}
