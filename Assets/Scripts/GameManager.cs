using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] obstaclesArray;
    public GameObject mouse;
    public GameObject frog;

    public GameObject frogsWinTitle;

    public GameObject miceWinTitle;

    public int numberOfObstacles;
    public int numberOfAnimals;

    public Vector3 mouseRotationAngles; 

    void Start()
    {
// ABSTRACTION
       AddStones();
       AddAnimals();

    }

// Methods for managing scenes
    public void LoadMainScene() 
        {
            SceneManager.LoadScene("MainScene");
            Time.timeScale = 1.0f;
        }
    public void LoadAbout() 
        {
            SceneManager.LoadScene("About");
        }
    public void LoadRules() 
        {
            SceneManager.LoadScene("Rules");
        }
        public void MainMenu() 
        {
            SceneManager.LoadScene("Start");
        }

// Methods for the end of the game

    public void FrogsWin()
    {
        frogsWinTitle.SetActive(true);
    }

    public void MiceWin()
    {
        miceWinTitle.SetActive(true);
    }

//Method for adding Stones
    public void AddStones()
    {
         numberOfObstacles = Random.Range(2, 6);
        for (int i = 0; i < numberOfObstacles; i++)
        {
            float randomStoneX = Random.Range(-8, 7);
            float randomStoneZ = Random.Range(-8, 8);
            Vector3 randomStonePosition = new Vector3(randomStoneX, 0.5f, randomStoneZ);
            Instantiate(obstaclesArray[Random.Range(0, obstaclesArray.Length)], randomStonePosition, Quaternion.identity);
        }
    }
//Method for adding Animals
    public void AddAnimals()
    {
        numberOfAnimals = 7;
        for (int i = 0; i < numberOfAnimals; i++)
        {
            float randomAnimalZ = Random.Range(7, -6);
            Quaternion rotation = Quaternion.Euler(mouseRotationAngles);
            float randomMouseX = Random.Range(-14, -10);
            Vector3 randomMousePosition = new Vector3(randomMouseX, 0.5f, randomAnimalZ);
            Instantiate(mouse, randomMousePosition, rotation);

            float randomFrogX = Random.Range(9, 13);
            Vector3 randomFrogPosition = new Vector3(randomFrogX, 0.5f, randomAnimalZ);
            Instantiate(frog, randomFrogPosition, Quaternion.identity);
        }
    }
}

