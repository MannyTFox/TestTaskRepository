using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipmentManager : MonoBehaviour
{

    [SerializeField] GameObject EquipmentTemplate;

    [SerializeField] GameObject headSlot;
    [SerializeField] GameObject chestSlot;
    [SerializeField] GameObject feetSlot;

    Item headSlotItem;
    Item chestSlotItem;
    Item feetSlotItem;

    public bool headSlotFull;
    public bool chestSlotFull;
    public bool feetSlotFull;


    GameObject player;

    private void Awake()
    {

        player = GameObject.FindGameObjectWithTag("Player");
       
    }

    public void EquipItem(Item item)
    {

        GameObject g;

        switch (item.slotType)
        {

            case "head":                
                if(headSlotFull == false)
                {
                    headSlotItem = item;
                    g = Instantiate(EquipmentTemplate, headSlot.transform, false);
                    g.GetComponent<EquipmentTemplateScript>().Create(item);

                    player.GetComponent<PlayerInventory>().items.Remove(item);
                    player.GetComponent<PlayerInventory>().equipedItems.Add(item);
                    player.GetComponent<PlayerInventory>().EquipmentHasChanged();
                    player.GetComponent<PlayerInventory>().InventoryHasChanged();

                    headSlotFull = true;
                }
                break;

            case "chest":
                if (chestSlotFull == false)
                {
                    chestSlotItem = item;
                    g = Instantiate(EquipmentTemplate, chestSlot.transform, false);
                    g.GetComponent<EquipmentTemplateScript>().Create(item);

                    player.GetComponent<PlayerInventory>().items.Remove(item);
                    player.GetComponent<PlayerInventory>().equipedItems.Add(item);
                    player.GetComponent<PlayerInventory>().EquipmentHasChanged();
                    player.GetComponent<PlayerInventory>().InventoryHasChanged();

                    chestSlotFull = true;
                }
                break;

            case "feet":
                if (feetSlotFull == false)
                {
                    feetSlotItem = item;
                    g = Instantiate(EquipmentTemplate, feetSlot.transform, false);
                    g.GetComponent<EquipmentTemplateScript>().Create(item);

                    player.GetComponent<PlayerInventory>().items.Remove(item);
                    player.GetComponent<PlayerInventory>().equipedItems.Add(item);
                    player.GetComponent<PlayerInventory>().EquipmentHasChanged();
                    player.GetComponent<PlayerInventory>().InventoryHasChanged();

                    feetSlotFull = true;
                }
                break;
   
        }

        
    }

    public void UnequipItem(Item item)
    {
        switch (item.slotType)
        {

            case "head":
                if (headSlotFull == true)
                {
                    player.GetComponent<PlayerInventory>().items.Add(item);
                    player.GetComponent<PlayerInventory>().equipedItems.Remove(item);
                    player.GetComponent<PlayerInventory>().EquipmentHasChanged();
                    player.GetComponent<PlayerInventory>().InventoryHasChanged();
                    headSlotItem = null;
                    headSlotFull = false;
                }
                break;

            case "chest":
                if (chestSlotFull == true)
                {
                    player.GetComponent<PlayerInventory>().items.Add(item);
                    player.GetComponent<PlayerInventory>().equipedItems.Remove(item);
                    player.GetComponent<PlayerInventory>().EquipmentHasChanged();
                    player.GetComponent<PlayerInventory>().InventoryHasChanged();
                    chestSlotItem = null;
                    chestSlotFull = false;
                }
                break;

            case "feet":
                if (feetSlotFull == true)
                {
                    player.GetComponent<PlayerInventory>().items.Add(item);
                    player.GetComponent<PlayerInventory>().equipedItems.Remove(item);
                    player.GetComponent<PlayerInventory>().EquipmentHasChanged();
                    player.GetComponent<PlayerInventory>().InventoryHasChanged();
                    feetSlotItem = null;
                    feetSlotFull = false;
                }
                break;

        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
