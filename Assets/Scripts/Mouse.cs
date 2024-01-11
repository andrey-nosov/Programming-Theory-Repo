using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// INHERITANCE
public class Mouse : Animal 
{
    public override void OnCollisionEnter(Collision collision)
        {

            if (collision.gameObject.CompareTag("Stone") || collision.gameObject.CompareTag("Frog"))
                {
                    audioSource.Play();
                }

        }
    // POLYMORPHISM
    public override void Bounciness () 
        {
            physicMaterial.bounciness = 1.0f;
        }
}
