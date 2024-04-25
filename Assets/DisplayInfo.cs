using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayInfo : MonoBehaviour
{
    public GameObject infoPanel; // Assign this in the inspector to your UI Panel
    public TextMeshProUGUI infoText; // Assign your TextMeshProUGUI component
    public Image infoImage; // Assign your Image component if you want to change the image dynamically

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player GameObject is tagged as "Player"
        {
            ShowInfoPanel();
        }
    }

    public void ShowInfoPanel()
    {
        infoPanel.SetActive(true); // Show the info panel

        // Unlock and show the cursor when displaying the UI
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Optional: Set text and image properties here if they need to change dynamically
        // infoText.text = "Your new text here";
        // infoImage.sprite = yourNewSprite; // Make sure you have a reference to yourNewSprite
    }

    public void CloseInfo()
    {
        infoPanel.SetActive(false); // Hide the info panel

        // Lock the cursor to the center of the screen and hide it for gameplay
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Add logic to resume game if it was paused when the UI was active
    }
}
