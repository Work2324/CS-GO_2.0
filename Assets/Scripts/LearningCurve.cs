using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogFormat("it's abs - {0} and it's pow - {1}", abs(-4f), pow(2f, 3));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public float abs(float number)
    {
        if (number >= 0)
        {
            return number;
        }
        else
        {
            return (-1) * number;
        }
    }

    public float pow(float number, int degree)
    {
        float temp = number;
        for (int i = 1; i < abs(degree); i++)
        {
            number = number * temp;

        }
        if (degree >= 0)
        {
            return number;
        }
        else
        {
            return 1 / number;
        }
    }
}
