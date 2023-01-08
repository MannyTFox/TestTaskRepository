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

        /////
        /*
        

        equipmentManager.EquipItem(item);

        Destroy(gameObject);
        */
        var player = GameObject.FindGameObjectWithTag("Player");
        var equipmentManager = GameObject.FindGameObjectWithTag("EquipmentPanel").GetComponent<EquipmentManager>();

        switch (item.slotType)
        {
            case "head":
                if(equipmentManager.headSlotFull == false)
                {
                    
                    player.GetComponent<PlayerInventory>().items.Remove(item);

                    equipmentManager.EquipItem(item);

                    Destroy(gameObject);
                }
            break;

            case "chest":
                if (equipmentManager.chestSlotFull == false)
                {
                    
                    player.GetComponent<PlayerInventory>().items.Remove(item);

                    equipmentManager.EquipItem(item);

                    Destroy(gameObject);
                }
                break;

            case "feet":
                if (equipmentManager.feetSlotFull == false)
                {
                    
                    player.GetComponent<PlayerInventory>().items.Remove(item);

                    equipmentManager.EquipItem(item);

                    Destroy(gameObject);
                }
                break;

        }
    }

   
 

}
