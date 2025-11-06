using UnityEngine;

public class Elf : EnemyParent
{
    private float timeElapsed;
    private Renderer renderer;
    private void Start()
    {
        MoveSpeed = 5;
        HP = 3;
        renderer = GetComponent<Renderer>();
        red = Resources.Load("RedMaterial", typeof(Material)) as Material;
    }
    private void Update()
    {
        Move();
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 3 && renderer.enabled == true)
        {
            timeElapsed = 0;
            ToggleVisibility();
        }
        if (timeElapsed >= 0.5 && renderer.enabled == false)
        {
            timeElapsed = 0;
            ToggleVisibility();
        }
    }
    private void ToggleVisibility()
    {
        if (HP > 0)
        {
            renderer.enabled = !renderer.enabled;
        }
    }
}
