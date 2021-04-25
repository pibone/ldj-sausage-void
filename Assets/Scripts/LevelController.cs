using UnityEngine;
using UnityEngine.SceneManagement;


public static class SCENES
{
    public const string
        MENU = "MainMenu",
        GAME = "MainGame",
        LEADERBOARD = "Leaderboard",
        END = "EndGame";
};

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(SCENES.GAME);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(SCENES.MENU);
    }

    public void LoadEnding()
    {
        SceneManager.LoadScene(SCENES.END);
    }

    public void LoadLeaderboard()
    {
        SceneManager.LoadScene(SCENES.LEADERBOARD);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}