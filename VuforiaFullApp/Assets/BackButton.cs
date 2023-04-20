using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    // The name of the main menu scene
    public string mainMenuSceneName = "MainMenu";

    // Update is called once per frame
    void Update()
    {
        // Check if the player presses the back button (in Android)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Check if the current scene is the main menu
            if (SceneManager.GetActiveScene().name == mainMenuSceneName)
            {
                // If the player is in the main menu, quit the application
                Application.Quit();
            }
            else
            {
                // If the player is not in the main menu, go back to the main menu
                SceneManager.LoadScene(mainMenuSceneName);
            }
        }
    }
}
