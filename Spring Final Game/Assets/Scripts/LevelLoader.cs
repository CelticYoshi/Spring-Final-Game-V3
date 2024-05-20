using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int _itemsCollected = 0;
    [SerializeField] private int _totalItemsCollected = 5;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private TextMeshProUGUI _itemsCollectText;
    [SerializeField] private CrossFade _crossFade;
    [SerializeField] private string _sceneName;
    [SerializeField] private Timer _timer;

    // Start is called before the first frame update
    void Start()
    {
        _sceneName = SceneManager.GetActiveScene().name;
        _itemsCollectText.text = "Items: " + _itemsCollected.ToString() + "/" + _totalItemsCollected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerHealth.GetPlayerHealth() <= 0 || _timer.GetGameTimer() == false)
        {
            StartCoroutine("EndLevel");
        }
    }

    IEnumerator EndLevel()
    {
        _crossFade.FadeIn();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level Select");
    }

    public void UpdateItemsCollected(int amount)
    {
        _itemsCollected += amount;
        _itemsCollectText.text = "Items: " + _itemsCollected.ToString() + "/" + _totalItemsCollected.ToString();
    
        if(_itemsCollected >= _totalItemsCollected)
        {
            if(_sceneName == "Level 3")
            StartCoroutine("YouWonGame");
        }

        if(_itemsCollected >= _totalItemsCollected && _sceneName == "Level 3")
        {
            StartCoroutine("YouWonGame");
        }
    }

    IEnumerator YouWonGame()
    {
        Debug.Log("YouWonGame");
        _crossFade.FadeIn();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("You Won");
    }
}
