using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //variables
    public Sprite faceSprite;
    Sprite backSprite;
    SpriteRenderer myRenderer;
    bool mouseOver = false;

    private void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        backSprite = myRenderer.sprite;
    }

    private void Update()
    {
        if (mouseOver)
        {
            myRenderer.sprite = faceSprite;
        }
    }

    private void OnMouseDown()
    {
        mouseOver = true;
    }
}
