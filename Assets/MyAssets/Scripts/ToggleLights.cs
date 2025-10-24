
using System.Collections.Generic;
using UnityEngine;

public class ToggleLights : MonoBehaviour
{
    [SerializeField] Light[] getLights;
    [SerializeField] AudioClip[] lightOn;
    [SerializeField] AudioClip lightOff;
    [SerializeField] AudioSource audioSource;

    void Start()
    {
        if (audioSource == null && GetComponent<AudioSource>() != null)
        {
            audioSource = GetComponent<AudioSource>(); //GetCompontent zonder een referentie naar een ander GameObject
            //verwijst altjd naar het GameObject waar dit SCRIPT zit
        }
    }

    void OnMouseDown()
    {
        ;
        foreach (Light l in getLights)
        {
            /* if (l.enabled)
                 l.enabled = false;
             else
                 l.enabled = true;*/
            l.enabled = !l.enabled;
            if (l.enabled)
            {
                if (lightOn.Length == 0) return;
                int randomIndex = Random.Range(0, lightOn.Length);
                if (lightOn[randomIndex] == null) return;
                audioSource.PlayOneShot(lightOn[randomIndex]);
            }
            else
            {
                if (lightOff == null) return;
                audioSource.PlayOneShot(lightOff);
            } }
    }
}
