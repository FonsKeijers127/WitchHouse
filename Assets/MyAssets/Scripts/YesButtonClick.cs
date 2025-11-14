using UnityEngine;
using UnityEngine.SceneManagement;
public class YesButtonClick : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public void OnClickYes()
    {
        Debug.Log("Closing scene");
        Application.Quit();
    }
}
