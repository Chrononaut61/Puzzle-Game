using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()   //Κουμπί για την μετάβαση από το μενού στο πρώτο επίπεδο
    {
        SceneManager.LoadScene("Start"); 
    }

    public void QuitGame()   
    {
        Application.Quit(); //Κουμπί για την έξοδο από το παιχίδι
    }

}
