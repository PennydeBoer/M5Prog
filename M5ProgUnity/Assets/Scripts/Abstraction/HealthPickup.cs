using UnityEngine;

public class HealthPickup : Collectables
{
    public override void OnCollect()
    {
        Debug.Log("Health restored!");
        player.GetComponent<Player>().Health += 20;
    }
}
