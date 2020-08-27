using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int Score;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "x " + Score;
    }


}
