using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopCanvasManager : MonoBehaviour
{
    bool uiEnabled;
    Canvas canvas;
    [SerializeField]Canvas interactCanvas;
    [SerializeField] TextMeshProUGUI goldDisplay;
    GameObject player;
    int playerGold;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GetComponent<Canvas>();
        uiEnabled = false;
    }

    private void Update()
    {
        goldDisplay.text = playerGold.ToString() + "g";
    }

    public void Open()
    {
        canvas.enabled = true;
        interactCanvas.enabled = false;
        playerGold = player.GetComponent<PlayerInventory>().gold;
        goldDisplay.text = playerGold.ToString();
        uiEnabled = true;  
    }

    public void Close()
    {
        canvas.enabled = false;
        interactCanvas.enabled = true;
        uiEnabled = false;
    }
}
