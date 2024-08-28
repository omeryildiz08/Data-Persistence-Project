using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public InputField playerNameInput; // Input field for entering the player's name
    public Text bestScoreText; // Text field to display the highest score

    void Start()
    {
        LoadBestScore(); // Load the highest score when the game starts
    }

    public void StartGame()
    {
        // Save the player's name to PlayerPrefs for use in the game scene
        string playerName = playerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", playerName);

        // Load the game scene (index 1 in the build settings)
        SceneManager.LoadScene(1);
    }

    public void LoadBestScore()
    {
        // Display the highest score and corresponding player name from MainGameManager
        bestScoreText.text = "Best Score: " + MainGameManager.Instance.bestScore + " Name: " + MainGameManager.Instance.playerName;
    }
}