using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string ItemName { get; protected set; }

    protected InventoryItem(string itemName)
    {
        ItemName = itemName;
    }
}
