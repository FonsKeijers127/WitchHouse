using UnityEngine;

public class TriggerMonkey : MonoBehaviour
{

    [SerializeField] AudioSource monkey;
    [SerializeField] AudioClip monkeyScream;
    [SerializeField] Light Monkeylight;
     
    void Start()
    {
         if (monkey == null && GetComponent<AudioSource>() != null)
        {
            monkey = GetComponent<AudioSource>();
        }
        Monkeylight.intensity = 0f;
    }
    void OnMouseOver()
    {
        monkey.PlayOneShot(monkeyScream);
        Monkeylight.intensity = 10f;

    }
    void OnMouseExit()
    {
        Monkeylight.intensity = 0f;
    }
}
