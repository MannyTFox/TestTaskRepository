using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipmentTemplateScript : MonoBehaviour
{

    public Item item;

    [SerializeField] Image itemImageDisplay;
   



    public void Create(Item _item)
    {
        item = _item;
        itemImageDisplay.sprite = item.itemImage;
        
    }

    public void UnEquip()
    {

        var equipmentManager = GameObject.FindGameObjectWithTag("EquipmentPanel").GetComponent<EquipmentManager>();

        equipmentManager.UnequipItem(item);

        var player = GameObject.FindGameObjectWithTag("Player");

        player.GetComponent<PlayerInventory>().items.Add(item);
        player.GetComponent<PlayerInventory>().ListHasChanged();
        player.GetComponent<PlayerInventory>().EquipmentHasChanged();

        Destroy(gameObject);
    }


}
