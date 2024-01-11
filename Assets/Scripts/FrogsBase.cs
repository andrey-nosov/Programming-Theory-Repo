using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogsBase : MonoBehaviour
{

 public GameObject TextMiceWin;
 public GameObject RestartButton;
 public GameObject MainMenuButton;
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mouse"))
        {
            TextMiceWin.SetActive(true);
            RestartButton.SetActive(true);
            MainMenuButton.SetActive(true);
            Time.timeScale = 0.0f;
        }
    }

}
