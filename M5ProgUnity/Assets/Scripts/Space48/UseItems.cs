using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseItems : MonoBehaviour
{
    public static event Action<float, string> ItemAction;
    public static event Action<string> MessageOnUse;
    public static event Action OnItemUse;
    [SerializeField] private Image itemImageHolder;
    private List<Color> items = new List<Color>();
    private PickupItems pickupItems;
    void Start()
    {
        PickupItems.OnItemPickUp += GetItems;
        pickupItems = gameObject.GetComponent<PickupItems>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && items.Count > 0 && pickupItems.activeItemIndex != -1)
        {
            OnItemUse?.Invoke();
            if (items[pickupItems.activeItemIndex] == Color.blue)
            {
                MessageOnUse?.Invoke(" +  Move Speed");
                ItemAction?.Invoke(5, "moveSpeed");
            }
            else if (items[pickupItems.activeItemIndex] == Color.red)
            {
                MessageOnUse?.Invoke(" + Fire Rate");
                ItemAction?.Invoke(0.1f, "cooldownTime");
            }
            else if (items[pickupItems.activeItemIndex] == Color.green)
            {
                MessageOnUse?.Invoke(" + Rotation Speed");
                ItemAction?.Invoke(10, "rotationSpeed");
            }
            items.RemoveAt(pickupItems.activeItemIndex);
            if (pickupItems.activeItemIndex > 0)
            {
                pickupItems.activeItemIndex--;
                itemImageHolder.color = items[pickupItems.activeItemIndex];
            }
            else if (items.Count == 0)
            {
                itemImageHolder.color = Color.white;
                pickupItems.activeItemIndex = -1;
                itemImageHolder.enabled = false;
            }
        }
    }
    void GetItems(Color item)
    {
        items.Add(item);
    }
}
