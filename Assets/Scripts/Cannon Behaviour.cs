using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehaviour : MonoBehaviour
{
    public GameObject ui;

    public AudioClip cannonFireSound;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Player")
       {
        ShowUI();
       }
    }

    public void ShootCannon()
    {

       GetComponent<AudioSource>().PlayOneShot(cannonFireSound);
    }

    public void HideUI()
    {
        ui.SetActive(false);
         Cursor.lockState = CursorLockMode.Locked;
         Cursor.visible = false;
    }

    public void ShowUI()
    {
        ui.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressYes()
    {
        HideUI();
        ShootCannon();
    }

    public void PressNo()
    {
        HideUI();
    }
}
