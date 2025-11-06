using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootShip : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;
    [SerializeField] private float cooldownTime = 3f;
    private float cooldownCounter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        UseItems.ItemAction += changeCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownCounter += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && cooldownCounter > cooldownTime)
        {
            GameObject laser = Instantiate(laserPrefab);
            laser.transform.position = transform.position;
            laser.transform.rotation = transform.rotation;
            Destroy(laser, 3f);

            cooldownCounter = 0f;

        }
    }
    void changeCooldown(float minusCooldownTime, string checkItemAction)
    {
        if (checkItemAction == "cooldownTime")
        {
            cooldownTime -= minusCooldownTime;
        }
    }
}
