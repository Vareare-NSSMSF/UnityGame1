using UnityEngine;
using UnityEngine.SceneManagement;

/* 
 * DESCRIPTION:
 * Handler for the menus.
 * 
 * IN DEPTH:
 * In this script, that should be put as a script to a gameHandler object inside a scene,
 * you can control the actions of a menu inside the game. This should work for both in-game
 * pause menu and the main-menu, as well as other sub-menus like settings and so on.
 * 
 * DATE: 26/06/2020
 * AUTHOR: VAREARE
 */
public class MenuHandler : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    
    public GameObject mainMenuUI;
    public GameObject settingsMenuUI;

    public GameObject pauseMenuCanvas;
    public GameObject pauseSettingsMenuUI;

    private GameObject currentUI;

    public void Start()
    {
        currentUI = mainMenuUI;
    }

    /* Method that changes the currect scene to the game one using the gameSceneName
     * as the name for the scene. */
    public void LoadGame()
    {
        Debug.Log("Game Loading");

        // Load the game scene.
        mainMenuCanvas.GetComponent<CanvasGroup>().interactable = false;
        mainMenuCanvas.GetComponent<Animator>().enabled = true;      


        // TODO
        // Call initialization of the other scene.
    }

    public void LoadMainMenu()
    {
        // Load the game scene.

        Debug.Log("Main Menu Loading");

        // TODO
        // Call initialization of the other scene.
    }

    public void LoadOptions()
    {
        Debug.Log("Settings Menu Loading");
    }

    public void LoadPauseOptions()
    {
        Debug.Log("Pause Menu Loading");
    }

    public void LoadPauseMenu()
    {
        Debug.Log("Pause Settings Menu Loading");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Application");
        Application.Quit();
    }
}
