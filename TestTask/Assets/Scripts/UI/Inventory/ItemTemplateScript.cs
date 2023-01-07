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


}
