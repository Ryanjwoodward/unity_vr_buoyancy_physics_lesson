/*
-----------------------------------------------------------------------------------
|   AUTHOR      |   Ryan Woodward
|   INSTITUTION |   Grand Canyon University
|   COURSE      |   CST320 - Computer Human Interaction
|   DATE        |   December 2, 2023
-----------------------------------------------------------------------------------
*/

//---------------------------------------------------------------------------------
//                      INCLUDES
//---------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.SceneManagement;

//---------------------------------------------------------------------------------
//                      CLASS DEFINITION
//---------------------------------------------------------------------------------

public class SceneController : MonoBehaviour
{
//---------------------------------------------------------------------------------
//                      FUNCTIONS
//---------------------------------------------------------------------------------

    // Function to load a new scene by name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("secondScene");
    }

    // Function to quit the application (for example, in the build settings)
    public void QuitGame()
    {
        Application.Quit();
    }
}
