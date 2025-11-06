using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CycleItems : MonoBehaviour
{
    [SerializeField] private Image itemImageHolder;
    private List<Color> items = new List<Color>();
    private PickupItems pickupItems;
    // Start is called before the first frame update
    void Start()
    {
        PickupItems.OnItemPickUp += GetItems;
        UseItems.OnItemUse += LoseItem;
        pickupItems = gameObject.GetComponent<PickupItems>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (items.Count > 0)
            {
                if (pickupItems.activeItemIndex < items.Count - 1)
                {
                    pickupItems.activeItemIndex++;
                }
                else
                {
                    pickupItems.activeItemIndex = 0;
                }
                itemImageHolder.color = items[pickupItems.activeItemIndex];
            }
            else
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
    void LoseItem()
    {
        items.RemoveAt(pickupItems.activeItemIndex);
    }
}
