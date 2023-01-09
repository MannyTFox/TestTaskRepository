using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] AudioClip buttonSound;
    [SerializeField] AudioClip closeSound;
    [SerializeField] AudioClip buySound;
    [SerializeField] AudioClip equipSound;

    AudioSource source;

    public void PlaySound(AudioClip clip)
    {
        source = GetComponent<AudioSource>();
        source.clip = clip;
        source.Play();
    }
    
}
