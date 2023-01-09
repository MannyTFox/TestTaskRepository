using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void equipmentChangedEventHandler();
public delegate void inventoryChangedEventHandler();

public class PlayerInventory : MonoBehaviour
{
    public AudioClip equipClip;
    

    public int gold;
    public List<Item> items = new List<Item>();
    public List<Item> equipedItems = new List<Item>();

    
        


    public void InventoryHasChanged()
    {
        GameObject.FindObjectOfType<SellPanelScript>().UpdateSellPanelDisplay();
        GameObject.FindObjectOfType<InventoryPanelScript>().UpdateInventoryDisplay();
        GameObject.FindObjectOfType<CanvasManager>().PlaySound(equipClip);
    }

    public void EquipmentHasChanged()
    {
        UpdateEquipmentDisplay();

    }

    public void UpdateEquipmentDisplay()
    {
        // Clear the current gear
        foreach (Transform child in transform)
        {
            if (child.gameObject.GetComponent<EquipmentRenderer>() != null)
            {
                Destroy(child.gameObject);
            }

        }

        // Create new gear for each item equipped
        foreach (var item in equipedItems)
        {
            GameObject g = Instantiate(item.itemObj, transform);
            g.GetComponent<EquipmentRenderer>().Create(item);
        }
    }
}
