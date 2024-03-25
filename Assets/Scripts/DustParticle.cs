using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem groundEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        { 
            groundEffect.Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            groundEffect.Stop();
        }
    }

}
