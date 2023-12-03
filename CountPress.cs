/*
-----------------------------------------------------------------------------------
|   AUTHOR      |   Ryan Woodward
|   INSTITUTION |   Grand Canyon University
|   COURSE      |   CST320 - Computer Human Interaction
|   DATE        |   December 2, 2023
|   FILE        |   CountPress.cs
|   DESCRIPTION |   This File is used to handle UI events in the Buoyancy Lesson
-----------------------------------------------------------------------------------
*/

//---------------------------------------------------------------------------------
//                      INCLUDES
//---------------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;
using TMPro;


//---------------------------------------------------------------------------------
//                      CLASS DEFINITION
//---------------------------------------------------------------------------------

public class CountPress : MonoBehaviour
{

//---------------------------------------------------------------------------------
//                      VARIABLES
//---------------------------------------------------------------------------------
    
    // Fields for Unity Editor Usage
    public TextMeshProUGUI totalQuestionsAnswered;
    public TextMeshProUGUI totalCorrectAnswers;
    public TextMeshProUGUI[] questionResults = new TextMeshProUGUI[5];




    
    private int correctButtonCount = 0;
    private int totalButtonPressCount = 0;

    int[] questionsForFeedback = new int[5];
    int correctIndexCounter = 0;

        string[] questionsArray = new string[]
        {
            "What is buoyancy?",
            "What is the principle that describes why ships float?",
            "If an object is floating in a fluid, what can be said about the forces acting on the object?",
            "The buoyant force is influenced by?",
            "If an object has a density greater than the density of the fluid it is placed in, the object will?"
        };

        string[] correctAnswersArray = new string[]
        {
            "The force exerted by a fluid on a submerged object",
            "Archimedes' principle",
            "Buoyant force equals the weight of the object",
            "All of the above: The density of the fluid, The volume of the object The mass of the object",
            "Sink"
        };




//---------------------------------------------------------------------------------
//                      FUNCTIONS
//---------------------------------------------------------------------------------

    void Start()
    {

    }

    public void OnButtonPress()
    {
        totalButtonPressCount++;
        totalQuestionsAnswered.text = totalButtonPressCount.ToString();
        
    }

    public void OnCorrectButtonPress()
    {
        OnButtonPress();
        correctButtonCount++;
        totalCorrectAnswers.text = correctButtonCount.ToString();
        questionsForFeedback[correctIndexCounter] = 1;
        correctIndexCounter++;
    }

    public void ProceedToFeedBack()
    {
        for (int idx = 0; idx < 5; idx++)
        {
            if (questionsForFeedback[idx] == 0)
            {
                questionResults[idx].text = correctAnswersArray[idx];
            }
            else
            {
                questionResults[idx].text = "Answered Correctly";
            }
        }

    correctButtonCount = 0;
    totalButtonPressCount = 0;

    questionsForFeedback = new int[5];
    correctIndexCounter = 0;


    }


}
