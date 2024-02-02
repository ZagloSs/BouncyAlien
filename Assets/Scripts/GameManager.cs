using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _gameObjectCanvas;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void GameOver()
    {
        _gameObjectCanvas.SetActive(true);
        
    }

    //Restart with space when dead
    private void Update()
    {
        if(_gameObjectCanvas.activeSelf) 
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                ReStart();
            }
        }
    }

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
