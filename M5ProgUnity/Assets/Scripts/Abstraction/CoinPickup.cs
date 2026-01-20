using UnityEngine;

public class CoinPickup : Collectables
{
    public override void OnCollect()
    {
        Debug.Log("Coin collected!");
        player.GetComponent<Player>().Points += 10;
    }
}
