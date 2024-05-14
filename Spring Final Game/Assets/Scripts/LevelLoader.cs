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

    // Start is called before the first frame update
    void Start()
    {
        _itemsCollectText.text = "Items: " + _itemsCollected.ToString() + "/" + _totalItemsCollected.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerHealth.GetPlayerHealth() <= 0)
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
    
        if(_itemsCollected > _totalItemsCollected)
        {
            StartCoroutine("EndLevel");
        }
    }
}
