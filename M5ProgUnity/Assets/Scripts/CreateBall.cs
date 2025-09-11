using System.Runtime.CompilerServices;
using UnityEngine;

public class CreateBall : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    private void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject ball = ColorCreateBall(RandomColor(), RandomPos(-10f, 10f));
            Destroy(ball,3f);
        }
    }
    private void Update()
    {  
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            GameObject ball = ColorCreateBall(RandomColor(), RandomPos(-9f,9f));
            Destroy(ball,3f);
            elapsedTime = 0f;
        }
    }

    private GameObject ColorCreateBall(Color c, Vector3 position)
    {
        GameObject ball = Instantiate(prefab,position,Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;

        material.SetColor("_Color", c);

        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", c);
        }
        return ball;
    }
    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);
        return randColor;
    }
    private Vector3 RandomPos(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        Vector3 randPos = new Vector3((float)x, (float)y,0);
        return randPos;
    }
}
