
using System.Collections.Generic;
using UnityEngine;
public class BattleManager : MonoBehaviour
{
    [SerializeField] private List<EnemyPoly> enemies;

    void Start()
    {
        // Maak verschillende enemy types
        enemies = new List<EnemyPoly>
        {
            new GameObject().AddComponent<Zombie>(),
            new GameObject().AddComponent<Goblin>(),
            new GameObject().AddComponent<Dragon>(),
            new GameObject().AddComponent<Witch>()
        };
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PRESSED - SPACE");
            // POLYMORFISME! We behandelen alle enemies hetzelfde,
            // maar elke enemy voert zijn eigen Attack() uit
            foreach (EnemyPoly enemy in enemies)
            {
                enemy.Attack(gameObject); // Verschillende implementaties!
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("PRESSED - D");
            // Alle enemies nemen damage, maar elk op zijn eigen manier
            foreach (EnemyPoly enemy in enemies)
            {
                if (enemy == null)
                {
                    enemies.Remove(enemy);
                    break;
                }
                enemy.TakeDamage(25f); // Zombies nemen minder, Goblins ontwijken misschien
            }
        }
    }
}
