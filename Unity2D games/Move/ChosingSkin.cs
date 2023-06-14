using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChosingSkin : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GameObject.Find("Good").GetComponent<SpriteRenderer>();
        //spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
       // if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
           // spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Space)) // If the space bar is pushed down
    //    {
    //         ChangeTheDamnSprite(); // call method to change sprite
    //    }
    // }

    public void ChangeTheDamnSprite()
    {
        //if (spriteRenderer)
       // {
            if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
            {
                spriteRenderer.sprite = sprite2;
            }
            else if (spriteRenderer.sprite == sprite2)
            {
                spriteRenderer.sprite = sprite3; // otherwise change it back to sprite1
            }
            else if (spriteRenderer.sprite == sprite3)
            {
                spriteRenderer.sprite = sprite4;
            }
            else if (spriteRenderer.sprite == sprite4)
            {
                spriteRenderer.sprite = sprite5;
            }
            else if (spriteRenderer.sprite == sprite5)
            {
                spriteRenderer.sprite = sprite6;
            }
            else if (spriteRenderer.sprite == sprite6)
            {
                spriteRenderer.sprite = sprite7;
            }
            else if (spriteRenderer.sprite == sprite7)
            {
                spriteRenderer.sprite = sprite8;
            }
            else if (spriteRenderer.sprite == sprite8)
            {
                spriteRenderer.sprite = sprite1;
            }
        //}
    }
}
