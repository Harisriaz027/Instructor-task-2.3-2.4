using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryOutOfBounds : MonoBehaviour
{
    private float lowerBound = -1.5f;
    void Update()
    {
        if (transform.position.y < lowerBound)
        {
            Time.timeScale = 1;
            Destroy(gameObject);
         }
    }
}
