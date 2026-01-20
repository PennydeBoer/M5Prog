using UnityEngine;
using UnityEngine.UI;

public class DelegateScoreboard : MonoBehaviour
{
    [SerializeField] private Text scoreboardText;
    [SerializeField] private Player player;
    private void Start()
    {
        Collectables.collected += UpdateScoreboard;
    }
    private void UpdateScoreboard()
    {
        scoreboardText.text = $"Points: {player.Points}";
    }
}
