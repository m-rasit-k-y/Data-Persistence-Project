using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    private static BestScoreManager instance;

    private Text bestScore;

    public static BestScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new BestScoreManager();
            }

            return instance;
        }
    }

    private void Awake()
    {
        instance = this;

        DontDestroyOnLoad(Instance);

        bestScore = GameObject.Find("BestScoreText").GetComponent<Text>();
    }

    private void Start()
    {
        bestScore.text = PlayerPrefs.GetString("PlayerName", bestScore.text) + ": " + PlayerPrefs.GetInt("Score");
    }

    private void OnLevelWasLoaded(int level)
    {
        bestScore = GameObject.Find("BestScoreText").GetComponent<Text>();

        bestScore.text = PlayerPrefs.GetString("PlayerName", bestScore.text)+ ": " + PlayerPrefs.GetInt("Score");
    }

}
