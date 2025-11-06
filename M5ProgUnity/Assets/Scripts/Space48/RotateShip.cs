using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateShip : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        UseItems.ItemAction += changeRotationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }
    void changeRotationSpeed(float speed, string checkItemAction)
    {
        if (checkItemAction == "rotationSpeed")
        {
            rotationSpeed += speed;
        }
    }
}
