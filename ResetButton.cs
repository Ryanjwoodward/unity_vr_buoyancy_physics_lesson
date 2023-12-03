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

//---------------------------------------------------------------------------------
//                      CLASS DEFINITION
//---------------------------------------------------------------------------------
public class ResetButton : MonoBehaviour
{

//---------------------------------------------------------------------------------
//                      VARIABLES
//---------------------------------------------------------------------------------

    // Define a structure to store object and its corresponding reset position
    [System.Serializable]
    public struct ObjectResetInfo
    {
        public Transform objectToReset;
        public Vector3 resetPosition;
    }

    // List of objects and their reset positions
    public ObjectResetInfo[] objectsToReset;

//---------------------------------------------------------------------------------
//                      FUNCTIONS
//---------------------------------------------------------------------------------

    void Start()
    {
        // Attach this method to the button's click event
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ResetObjects);
    }

    void ResetObjects()
    {
        foreach (var objInfo in objectsToReset)
        {
            // Reset the object's position
            objInfo.objectToReset.position = objInfo.resetPosition;
        }
    }
}
