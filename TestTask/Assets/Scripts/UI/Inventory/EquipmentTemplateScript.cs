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

      

        Destroy(gameObject);
    }


}
