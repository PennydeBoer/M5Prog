using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Scoreboard : MonoBehaviour
{
    private int score;
    private TMP_Text m_Text;
    void Start()
    {
        m_Text = GetComponent<TMP_Text>();
        Pickup.onPickup += AddScore;
    }
    private void AddScore()
    {
        score++;
        m_Text.text = "Score: " + score;
    }
}
