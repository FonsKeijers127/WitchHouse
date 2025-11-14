using UnityEngine;

public class TriggerPotionAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    void OnMouseDown()
    {
        
        animator.SetTrigger("_playAnimation");
    }
}
