using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Messages : MonoBehaviour
{
    [SerializeField] private TMP_Text messageField;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowMessage("Welcome to Space 4 8. \n Move your ship with the arrows or WASD. \n Shoot with SPACE. \n Gather pickups and cycle with 'Left CTR'.  \n  Use pickups with 'E'.", 5f));
        UseItems.MessageOnUse += ItemsUsed;
    }
    IEnumerator ShowMessage(string message, float time)
    {
        messageField.enabled = true;
        messageField.text = message;
        yield return new WaitForSeconds(time);
        messageField.enabled = false;
    }

    void ItemsUsed(string itemMessage)
    {
        StartCoroutine(ShowMessage(itemMessage, 3f));
    }
}
