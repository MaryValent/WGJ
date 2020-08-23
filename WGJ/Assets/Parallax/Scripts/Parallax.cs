using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    private Renderer back;
    private float vel;
    private string nomeBack;

    void Start()
    {

        back = GetComponent<Renderer>();
        nomeBack = this.gameObject.tag;

    }

    // Update is called once per frame
    void Update()
    {



        switch (nomeBack)
        {

            case "ceu1":
                vel = 0.1f;
                break;

            case "ceu2":
                vel = 0.2f;
                break;

            case "ceu3":
                vel = 0.4f;
                break;

        }

        Vector2 offset = new Vector2(vel * Time.deltaTime, 0);

        back.material.mainTextureOffset += offset;

    }
}