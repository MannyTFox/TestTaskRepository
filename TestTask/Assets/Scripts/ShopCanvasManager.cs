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

        

        if(uiEnabled == true)
        {
            canvas.enabled = true;
            interactCanvas.enabled = false;
            playerGold = player.GetComponent<PlayerInventory>().gold;
            goldDisplay.text = playerGold.ToString();
        }
        else
        {
            canvas.enabled = false;
            interactCanvas.enabled = true;
        }

        
    }

    public void Open()
    {
        uiEnabled = true;  
    }

    public void Close()
    {
        uiEnabled = false;
    }
}
