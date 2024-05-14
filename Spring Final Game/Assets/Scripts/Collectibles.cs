using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private int value = 1;
    [SerializeField] private LevelLoader _levelLoader;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _levelLoader.UpdateItemsCollected(value);
            Destroy(this.gameObject);
        }
    }
}
