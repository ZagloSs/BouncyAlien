using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameObjectCanvas;
    public static CanvasManager Instance;
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }

    }

    private void Update()
    {
        if (_gameObjectCanvas.activeSelf)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                GameManager.instance.ReStart();
            }
        }
    }
    public void GameOver()
    {
        _gameObjectCanvas.SetActive(true);

    }
}
