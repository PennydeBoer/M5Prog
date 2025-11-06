using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    protected float MoveSpeed=2;
    protected float HP=5;
    protected Material red;

    private void Start()
    {
        red = Resources.Load("RedMaterial",  typeof(Material)) as Material;
    }
    void Update()
    {
        Move();
    }
    protected void Move()
    {
        if (HP > 0)
        {
            transform.position = transform.position + Camera.main.transform.right * MoveSpeed * Time.deltaTime;
        }
        else
        {
            GetComponent<MeshRenderer>().material = red;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        {
             HP--;
        }
       
    }
}
