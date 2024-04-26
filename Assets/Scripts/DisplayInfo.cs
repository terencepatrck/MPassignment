using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayInfo : MonoBehaviour
{
    
    public GameObject infoPanel; 
    public TextMeshProUGUI infoText; 
    public Image infoImage; 
    public string message; 
    public Sprite image; 

    // This method is called when another collider enters the trigger collider attached to the object this script is on.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has triggered the interaction.
        if (other.CompareTag("Player")) 
        {
            ShowInfoPanel(); // Call to display the information panel.
        }
    }

    // Method to activate the info panel and display content.
    public void ShowInfoPanel()
    {
        infoPanel.SetActive(true); // Activate the panel.

        // Set the text and image from the specified properties in the Inspector.
        infoText.text = message; // Display the assigned message.
        if (infoImage != null && image != null) 
        {
            infoImage.sprite = image; 
        }

        
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true; 
    }

    // Method to hide the information panel and reset gameplay settings.
    public void CloseInfo()
    {
        infoPanel.SetActive(false); // Deactivate the panel.

        
        Cursor.lockState = CursorLockMode.Locked; 
        Cursor.visible = false; 
        
    }
}
