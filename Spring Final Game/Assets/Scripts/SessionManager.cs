using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SessionManager : MonoBehaviour
{
    public int levelSelectSceneNumber;
    public int levelOneNumber;
    public int levelTwoNumber;
    public int levelThreeNumber;
    public int levelFourNumber;

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(levelSelectSceneNumber);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

    public void OnLevelOnePressed()
    {
        SceneManager.LoadScene(levelOneNumber);
    }
    
    public void OnLevelTwoPressed()
    {
        SceneManager.LoadScene(levelTwoNumber);
    }

    public void OnLevelThreePressed()
    {
        SceneManager.LoadScene(levelThreeNumber);
    }

    public void OnLevelFourPressed()
    {
        SceneManager.LoadScene(levelFourNumber);
    }
}

