using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    public static Score instance;

    [SerializeField] private TextMeshProUGUI scoreTxt;
    private int score = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScore()
    {
        score++;
        scoreTxt.text = score.ToString();
    }

    public int getScore()
    {
        return score;
    }
}
