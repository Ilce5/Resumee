using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    private float upDown = -100f;
    public Rigidbody2D rigidBody;
    private float increase = -2f;

    void Start()
    {
        // right/(-)left - Up/(-)Down
        rigidBody.AddForce(new Vector2(0f, upDown));
    }
    // Update is called once per frame
    void Update()
    {
        upDown += increase * Time.deltaTime;
    }
}
