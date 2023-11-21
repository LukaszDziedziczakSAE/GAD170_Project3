using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SmokeBomb : MonoBehaviour
{
    public Rigidbody Rigidbody {  get; private set; }
    [SerializeField] ParticleSystem smokeEffect;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") return;

        Instantiate(smokeEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
