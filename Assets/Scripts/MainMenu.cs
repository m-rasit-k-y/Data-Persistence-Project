using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Text nameText;
    public void LoadGame()
    {
        if (nameText.text != "")
        {
            PlayerPrefs.SetString("PlayerNameMenu", nameText.text);

            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("NamePlease");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
