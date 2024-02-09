using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScore;
    // Start is called before the first frame update
    void Start()
    {
        
        bestScore.text = PlayerPrefs.GetInt("bs", 0).ToString();
    }


    public void StartGame()
    {
        GameManager.instance.playerPos = AutoJumpMenu.instance.GetPos();
        SceneManager.LoadScene("Gameplay");
    }
}
