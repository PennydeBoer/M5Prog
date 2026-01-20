using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 20f; //Snelheid van de speler
    [SerializeField] private int health, points;
    public int Health
    {
        get { return health; }
        set { if (health >= 100) return;
            health = value; }
    }

    public int Points
    {
        get { return points; }
        set { points = value; }
    }
    void Update()
    {
        float moxeX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moxeZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 move = new Vector3(moxeX, 0f, moxeZ);
        transform.Translate(move);
        if (health > 0) return;
        Destroy(gameObject);
    }
}
