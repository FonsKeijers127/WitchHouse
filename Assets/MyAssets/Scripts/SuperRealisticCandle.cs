using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    Light getLight => GetComponent<Light>();
    float originalIntensity = 1f;
    float counter = 0f;
    [SerializeField] float updateRate = 0.1f;
    void Start()
    {
        originalIntensity = getLight.intensity;
    }

    
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= updateRate)
        {
            getLight.intensity = UnityEngine.Random.Range(0.025f, originalIntensity);
            counter = 0f;
        }
    }
}
