using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public delegate void inventoryChangedEventHandler();

public class PlayerInventory : MonoBehaviour
{

    public event inventoryChangedEventHandler OnInventoryChanged;

    public int gold;
    public List<Item> items = new List<Item>();

    public void ListHasChanged()
    {
        OnInventoryChanged?.Invoke();
    }
}
