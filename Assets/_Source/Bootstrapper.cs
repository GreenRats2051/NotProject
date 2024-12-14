using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public Score score;

    void Start()
    {
        score = new Score();
        score.InitializeScore(5);
    }
}
