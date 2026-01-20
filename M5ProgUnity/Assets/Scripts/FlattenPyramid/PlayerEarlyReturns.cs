using UnityEngine;

public class PlayerEarlyReturns : MonoBehaviour
{
    public bool IsAlive;
    public int AttackCooldown;
    public Target target;
    public int Mana;
    public int Health;
    public bool WeaponEquipped;
    public bool IsStunned;
    public bool IsSlowed;
    public bool HasBuff(string buffName)
    {
        return true;
    }
}
