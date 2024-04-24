using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{

    public GameObject instructionsPanel;  // Drag the panel to this field in the inspector

    void Start()
    {
        instructionsPanel.SetActive(true);  // Ensure this line is present and correct
    }

    public void HideInstructions()
    {
        Debug.Log("Attempting to hide panel");  // This will confirm the function is called
        instructionsPanel.SetActive(false);
    }
}

}
