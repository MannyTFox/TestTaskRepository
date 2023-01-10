using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{

    public float interactDistance;

    [SerializeField] AudioClip buttonSound;
    [SerializeField] AudioClip closeSound;
    [SerializeField] AudioClip buySound;
    [SerializeField] AudioClip equipSound;

    GameObject player;
    GameObject shopkeep;
    GameObject interactCanvas;

    AudioSource source;


    private void Start()
    {
        interactCanvas = GameObject.Find("InteractCanvas");
        interactCanvas.GetComponent<Canvas>().enabled = false;

    }
    public void PlaySound(AudioClip clip)
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
        source.Play();
    }

    private void Update()
    {
        CheckPlayerShopkeepDistance();
    }

    void CheckPlayerShopkeepDistance()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        shopkeep = GameObject.FindGameObjectWithTag("Shopkeep");
        var dialogueCanvas = GameObject.Find("DialogueCanvas");

        if (Vector2.Distance(player.transform.position, shopkeep.transform.position) <= interactDistance)
        {
            interactCanvas.GetComponent<Canvas>().enabled = true;
            dialogueCanvas.GetComponent<Canvas>().enabled = true;
        }
        else
        {
            interactCanvas.GetComponent<Canvas>().enabled = false;
            dialogueCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
}
