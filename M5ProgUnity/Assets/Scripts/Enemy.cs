using TreeEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Camera.main.transform.forward * moveSpeed * Time.deltaTime;
    }
}
