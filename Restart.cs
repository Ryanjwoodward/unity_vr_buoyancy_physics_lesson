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
    using System.Collections;
    
//---------------------------------------------------------------------------------
//                      CLASS DEFINITION
//---------------------------------------------------------------------------------
    public class Restart : MonoBehaviour {
    
//---------------------------------------------------------------------------------
//                      FUNCTIONS
//---------------------------------------------------------------------------------

    	public void RestartGame() {
    		SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    	}
    
    }