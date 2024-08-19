using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemovement : MonoBehaviour
{

    public float movespeed = 20F;
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed * Time.deltaTime);
    }
}
