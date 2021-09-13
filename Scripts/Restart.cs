using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;

    
    void Update()
    {
        if (Input.GetKey(keyRestart))  //Ορίζουμε κάποιο κουμπί της επιλογής μας για την επανεκκίνηση του επιπέδου/σκηνής
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
