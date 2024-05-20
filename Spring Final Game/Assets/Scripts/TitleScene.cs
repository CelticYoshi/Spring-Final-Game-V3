using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    public int startingScene;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(startingScene);
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

}
