using UnityEngine;

public class TriggerBook : MonoBehaviour
{
    [SerializeField] Animator animator;
    public void OnMouseDown()
    {
        animator.SetTrigger("_bookTrigger");
    }
    
        
    

 
}
