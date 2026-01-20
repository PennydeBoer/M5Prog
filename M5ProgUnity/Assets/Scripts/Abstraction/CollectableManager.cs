using System.Collections.Generic;
using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    private Collectables[] collectables;
    void Start()
    {
        collectables = FindObjectsOfType<Collectables>();
        Debug.Log($"Total collectables: {collectables.Length}");
        Collectables.collected += OnCollect;
    }

    private void OnCollect()
    {
        collectables = FindObjectsOfType<Collectables>();
        Debug.Log($"Collectable collected! Remaining: {collectables.Length-1}");
    }
}
