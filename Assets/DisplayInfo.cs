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
    public string message; // Message to display, set this for each object in the Inspector
    public Sprite image; // Image to display, set this for each object in the Inspector

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

        // Update the text and image with dynamic content specific to this object
        infoText.text = message; // Use the message set in the Inspector
        if (infoImage != null && image != null) // Check if an image component and sprite are assigned
        {
            infoImage.sprite = image; // Update the image displayed
        }

        // Unlock and show the cursor when displaying the UI
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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
