using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    [SerializeField]
    string strTag;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)   //Αυτόματη επανεκκίνηση επιπέδου μέσω επαφής με συγκεκριμένο αντικείμενο
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
