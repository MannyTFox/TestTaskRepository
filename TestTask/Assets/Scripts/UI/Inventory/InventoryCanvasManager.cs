using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryCanvasManager : MonoBehaviour
{
    bool uiEnabled;
    Canvas canvas;
    [SerializeField] Canvas interactCanvas;
    [SerializeField] TextMeshProUGUI goldDisplay;
    GameObject player;

    private void Update()
    {
        //display player gold in inventory
        //goldDisplay.text = player.GetComponent<PlayerInventory>().gold.ToString();
    }

    private void Start()
    {
        //get references and start the game with this canvas disabled
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GetComponent<Canvas>();
        uiEnabled = false;
    }

    public void Open()
    {
        canvas.enabled = true;
        interactCanvas.enabled = false;
        uiEnabled = true;
    }

    public void Close()
    {
        canvas.enabled = false;
        interactCanvas.enabled = true;
        uiEnabled = false;
    }
}
