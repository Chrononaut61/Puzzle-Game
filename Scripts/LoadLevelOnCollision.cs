using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;

    [SerializeField]
    string strSceneName;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag) //Φόρτωση επιπέδου/σκηνής μέσω επαφής με αντικείμενο
        SceneManager.LoadScene(strSceneName);
    }
}
