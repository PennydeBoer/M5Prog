using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    void Start()
    {
        if (tag == "Player")
        {
            UseItems.ItemAction += ChangeMoveSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Player")
        {
            Move(Input.GetAxis("Vertical"));
        }
        else
        {
            Move(1);
        }
    }
    void Move(float Input)
    {
        transform.position = transform.position + transform.forward * moveSpeed * Input * Time.deltaTime;
    }
    void ChangeMoveSpeed(float speed, string checkItemAction)
    {
        if (checkItemAction == "moveSpeed")
        {
            moveSpeed += speed;
        }
    }
}
