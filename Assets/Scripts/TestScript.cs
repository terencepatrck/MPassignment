using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TestScript : MonoBehaviour
{

   [SerializeField] private ConfirmationWindow myConfirmationWindow;
   public string nextSceneName = "Main"; 
    // Start is called before the first frame update
    void Start()
    {
        OpenConfirmationWindow("Hi Welcome to my Scene");

    }

    private void OpenConfirmationWindow(string message)
    {
        myConfirmationWindow.gameObject.SetActive(true);
        myConfirmationWindow.yesButton.onClick.AddListener(YesClicked);
    }

   private void YesClicked()
   {
    myConfirmationWindow.gameObject.SetActive(false);
    Debug.Log("Yes CLick");
       SceneManager.LoadScene(nextSceneName);
   }
}
