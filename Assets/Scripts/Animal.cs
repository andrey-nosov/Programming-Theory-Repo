using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    public float impulseForce { get; private set; }  
    public float timeBetweenImpulses { get; private set; }
    private Rigidbody rb;
    private float timer = 0.0f;

    public AudioSource audioSource;

    public PhysicMaterial physicMaterial;

    

    void Start()
    {
        impulseForce = 1.3f;
        timeBetweenImpulses = 2.5f;
         rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        Bounciness();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeBetweenImpulses)
        {
            float randomX = Random.Range(-30.0f, 30.0f);
            float randomZ = Random.Range(-10.0f, 10.0f);
            rb.AddForce(new Vector3(randomX, 0.0f, randomZ) * impulseForce, ForceMode.Impulse);
            timer = 0.0f;
        }
    }

    public virtual void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Stone"))
        {
             audioSource.Play();
        }

    }
    // POLYMORPHISM
    public virtual void Bounciness () 
        {
            physicMaterial.bounciness = 0.0f;
        }



    



}
