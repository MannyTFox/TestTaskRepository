using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class Item : ScriptableObject
{
    public Sprite itemImage;
    public string itemName;
    public int itemPrice;
}
