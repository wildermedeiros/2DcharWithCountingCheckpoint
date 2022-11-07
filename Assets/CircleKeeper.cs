using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleKeeper : MonoBehaviour
{
    void Update()
    {
        if (transform.childCount <= 0)
        {
            print("vitoria");
        }

        if(transform.childCount >= 20)
        {
            print("Wasted");
        }
    }

    public int GetCircleCount()
    {
        return transform.childCount;
    }
}
