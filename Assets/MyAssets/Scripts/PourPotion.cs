using UnityEngine;

public class PourPotion : MonoBehaviour
{
  [SerializeField] Animator anim;
    void OnMouseDown()
    {
        anim.SetTrigger("PotionPour");
    }
}
