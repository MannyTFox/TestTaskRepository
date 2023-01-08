using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentRenderer : MonoBehaviour
{
    

   public void Create(Item item)
    {
        GetComponent<SpriteRenderer>().sprite = item.itemImage;

    }
}
