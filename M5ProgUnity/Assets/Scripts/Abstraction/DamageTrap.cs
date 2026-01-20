using UnityEngine;

public class DamageTrap : Collectables
{

    public override void OnCollect()
    {
        Debug.Log("BOOM!!");
        player.GetComponent<Player>().Health -= 5;
    }
}
