using UnityEngine;

public class Witch : EnemyPoly
{
    private float invisibleChance = 0.5f;
    private bool invisible;
    private float mischance = 0.5f;
    private void Start()
    {
        gameObject.name = "Witch";
        health = 50;
    }
    public override void TakeDamage(float damage)
    {
        if (Random.value < invisibleChance && !invisible)
        {
            Debug.Log("Witch is onzichtbaar!");
            invisible = true;
            return;
        }
        if (invisible)
        {
            invisible = false;
            Debug.Log("Witch is weer zichtbaar");
            return;
        }
        base.TakeDamage(damage); // Gewone damage berekening
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        if (Random.value < mischance)
        {
            Debug.Log($"Witch casts Lightning upon {target.name}");
            return;
        }
        Debug.Log($"Witch casts Lightning and misses");
    }
}
