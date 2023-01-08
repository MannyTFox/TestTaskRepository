using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    public string slotType;
    public Sprite itemImage;
    public string itemName;
    public int itemPrice;
    public GameObject itemObj;
}
