﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGood : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    // Update is called once per frame
    void Update()
    {
            if (Input.GetMouseButtonDown(0))
            {
                pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            }
            if (Input.GetMouseButton(0))
            {
                touchStart = true;
                pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            }
            else
            {
                touchStart = false;
            }
    }
    private void FixedUpdate()
    {
        if (player != null){
            if (touchStart)
            {
                Vector2 offset = pointB - pointA;
                Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
                moveCharacter(direction * -1);
            }
        }
    }
        void moveCharacter(Vector2 direction)
        {
            player.Translate(direction * speed * Time.deltaTime);
        }

}
