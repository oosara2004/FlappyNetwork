using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerHops;
    public Text hopsText;
    public GameObject gameOverScreen;

    public void addHop(int HopToAdd)
    {
        playerHops = playerHops + HopToAdd;

        hopsText.text = playerHops.ToString();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
    
}
