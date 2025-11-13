using System;
using UnityEngine;

public class TriggerMonkey : MonoBehaviour
{
    [SerializeField] AudioClip monkey;
    [SerializeField] Light Monkeylight;
    void Start()
    {
        Monkeylight.intensity = 0f;
    }
    void OnMouseOver()
    {
        
        Monkeylight.intensity = 10f;
    }
    void OnMouseExit()
    {
        Monkeylight.intensity = 0f;
    }
}
