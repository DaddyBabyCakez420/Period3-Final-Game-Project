using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOverScript GameOverScript;
    int scoreValue = 0;
    public void EndGame()
    {
        GameOverScript.Setup(scoreValue);
        Debug.Log("GAME OVER");
    }
}
