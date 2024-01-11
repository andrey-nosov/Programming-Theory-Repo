using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// INHERITANCE
public class Frog : Animal 
{
    
    public override void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Stone") || collision.gameObject.CompareTag("Mouse"))
            {
                audioSource.Play();
            }
            
        if (collision.gameObject.CompareTag("Mouse"))
            {
                audioSource.Play();
                Destroy(gameObject);
                Destroy(collision.gameObject);
                
            }



    }
    // POLYMORPHISM
    public override void Bounciness () 
        {
            physicMaterial.bounciness = 0.5f;
        }


}
