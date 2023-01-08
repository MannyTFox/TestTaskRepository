using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemTemplateScript : MonoBehaviour
{
    public Item item;

    [SerializeField]Image itemImageDisplay;
    [SerializeField]TextMeshProUGUI itemNameDisplay;



    public void Create(Item _item)
    {
        item = _item;
        itemImageDisplay.sprite = item.itemImage;
        itemNameDisplay.text = item.itemName;
    }

    public void Equip()
    {
        //remove item from inventory to avoid item duplication glitch
        var player = GameObject.FindGameObjectWithTag("Player");

        player.GetComponent<PlayerInventory>().items.Remove(item);
        /////

        var equipmentManager = GameObject.FindGameObjectWithTag("EquipmentPanel").GetComponent<EquipmentManager>();

        equipmentManager.EquipItem(item);

        Destroy(gameObject);
    }

   
 

}
