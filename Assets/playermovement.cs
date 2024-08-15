using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D playerRB;
    public float force = 20F;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            playerRB.velocity = (Vector2.up * force);
        }
    }
}
