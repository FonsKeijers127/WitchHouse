
using UnityEngine;


public class NoButtonClick : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public void OnClickNo()
    {
        panel.SetActive(false);
    }
}
