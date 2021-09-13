﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnCollision : MonoBehaviour
{                                               //Για την εκχώριση αντικειμένων στην Unity με ιδιότητα καταστροφής
    [SerializeField]
    string strTag;

    [SerializeField]
    bool bDestroySelf = false;

    [SerializeField]
    bool bDestroyOther = false;

    private void OnCollisionEnter(Collision collision) //Δημιουργία μηχανισμού καταστροφής αντικειμένων με την επαφή
    {
        if (collision.collider.tag == strTag)
        {
            if (bDestroySelf)
                Destroy(this.gameObject);
            if (bDestroyOther)
                Destroy(collision.gameObject);
        }
    }
}
