using UnityEngine;

public class Brute : EnemyParent
{
    private void Start()
    {
        MoveSpeed = 1;
        HP = 10;
        red = Resources.Load("RedMaterial", typeof(Material)) as Material;
    }
    private void Update()
    {
        Move();
    }
}
