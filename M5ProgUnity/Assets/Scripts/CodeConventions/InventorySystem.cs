using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] private List<InventoryItem> _worldItems;
    private int _worldGun;
    private int _worldMedipack;
    private int _worldKeycard;
    private int _inventoryGun;
    private int _inventoryMedipack;
    private int _inventoryKeycard;
    void Start()
    {
        //Start text
        Debug.Log("Press/hold 'G' to pickup/drop guns.");
        Debug.Log("Press/hold 'M' to pickup/drop medipacks.");
        Debug.Log("Press/hold 'K' to pickup/drop keycards.");
        //get worlditems
        foreach (InventoryItem item in _worldItems)
        {
            if (item.ItemName == "Gun")
            {
                _worldGun++;
            }
            if (item.ItemName == "Medipack")
            {
                _worldMedipack++;
            }
            if (item.ItemName == "Keycard")
            {
                _worldKeycard++;
            }
        }
        //writeline
        WriteConsoleLine();
    }
    private void Update()
    { 
        //get keyinput
        switch(Input.inputString)
        {
            case "g":
                _worldGun--;
                _inventoryGun++;
                WriteConsoleLine() ; 
                break;
            case "m":
                _worldMedipack--;
                _inventoryMedipack++;
                WriteConsoleLine();
                break;
            case "k":
                _worldKeycard--;
                _inventoryKeycard++;
                WriteConsoleLine();
                break;
        }
    }
    private void WriteConsoleLine()
    {
        //items
        Debug.Log("Items in world:");

        
        Debug.Log($"Medipacks: {_worldMedipack} ");
        Debug.Log($"Guns: {_worldGun} ");
        Debug.Log($"Keycards: {_worldKeycard} ");

        Debug.Log("Items in inventory:");
        Debug.Log($"Medipacks: {_inventoryMedipack} ");
        Debug.Log($"Guns: {_inventoryGun} ");
        Debug.Log($"Keycards: {_inventoryKeycard} ");
    }
    
}
