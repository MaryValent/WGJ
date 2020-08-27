using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectPenas : MonoBehaviour
{
    public AudioSource collectSound;


    void OnTriggerEnter2D(Collider2D other)
    {
        collectSound.Play();
        ScoreSystem.Score += 1;
        Destroy(gameObject);
    }
}
