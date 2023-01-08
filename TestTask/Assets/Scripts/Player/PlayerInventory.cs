using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void equipmentChangedEventHandler();
public delegate void inventoryChangedEventHandler();

public class PlayerInventory : MonoBehaviour
{

    public event inventoryChangedEventHandler OnInventoryChanged;
    public event equipmentChangedEventHandler OnEquipmentChanged;

    public int gold;
    public List<Item> items = new List<Item>();
    public List<Item> equipedItems = new List<Item>();

    
        


    public void ListHasChanged()
    {
        OnInventoryChanged?.Invoke();
    }

    public void EquipmentHasChanged()
    {
        OnEquipmentChanged?.Invoke();
        DisplayGear();
    }

    public void DisplayGear()
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
