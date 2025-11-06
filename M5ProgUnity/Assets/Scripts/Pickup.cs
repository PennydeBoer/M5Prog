using System;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public static event Action onPickup;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onPickup?.Invoke();
            Destroy(gameObject);
        }
    }
}
