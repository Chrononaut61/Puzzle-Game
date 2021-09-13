using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    public AudioSource impactSound;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 1)  //Αναπαραγωγή ήχου με την επαφή αντικειμένου
        {
            impactSound.Play();
        }
    }
}
