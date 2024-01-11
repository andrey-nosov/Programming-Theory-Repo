using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiceBase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextFrogsWin;
    public GameObject RestartButton;
    public GameObject MainMenuButton;
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Frog"))
        {
            TextFrogsWin.SetActive(true);
            RestartButton.SetActive(true);
            MainMenuButton.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

}

