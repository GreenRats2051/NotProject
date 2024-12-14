using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public Bootstrapper bootstrapper;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            bootstrapper.score.DecrementScore();
        }
    }
}
