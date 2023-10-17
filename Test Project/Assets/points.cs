using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public Movement score;

    void OnCollisionEnter2D()
    {
        score.score++;
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-3, 3), 0);
    }
}
