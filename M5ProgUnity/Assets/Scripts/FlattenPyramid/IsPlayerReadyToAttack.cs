
using UnityEngine;
public class PlayerReady
{
    public bool IsPlayerReadyToAttack(PlayerEarlyReturns player)
    {
        if (player == null) return false;
        if (!player.IsAlive) return false;
        if (player.AttackCooldown > 0) return false;
        if (player.target == null) return false;
        if (!player.target.IsAlive) return false;
        if (Vector3.Distance(player.transform.position, player.target.transform.position) >= 5f) return false;
        bool ConditionsMet =
            (player.Mana >= 20 && player.WeaponEquipped) ||
            (player.Health > 30 && player.HasBuff("Strength"));
        if (!ConditionsMet) return false;
        if (player.IsStunned) return false;
        if (player.IsSlowed) return false;
        return true;
    }
}