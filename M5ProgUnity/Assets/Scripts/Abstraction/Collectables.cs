using System;
using UnityEngine;

public abstract class Collectables : MonoBehaviour
{
    public delegate void OnCollected();
    public static OnCollected collected;
    protected GameObject player;
    public abstract void OnCollect();
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnTriggerEnter(Collider other)
    {   
        OnCollect();
        Destroy(gameObject);
        collected?.Invoke();
    }
}
