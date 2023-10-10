using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.AnimatedValues;
using UnityEngine;
using TMPro;

public class AdventurePlayer : MonoBehaviour
{
    //refernces
    Rigidbody myBody;
    Animator myAnim;
    public SpriteRenderer myRenderer;
    public GameObject mySprite;

    //variables
    [SerializeField] float playerSpeed = 0.1f;

    void Start()
    {
        //references
        myBody = GetComponent<Rigidbody>();
        myAnim = mySprite.GetComponent<Animator>();
        myRenderer = mySprite.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

        myRenderer.sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;

        //player movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, playerSpeed * Time.deltaTime, 0);
            myAnim.SetBool("UpWalk", true);
            myAnim.SetBool("RightWalk", false);
            myAnim.SetBool("DownWalk", false);
            myAnim.SetBool("LeftWalk", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -playerSpeed * Time.deltaTime, 0);
            myAnim.SetBool("DownWalk", true);
            myAnim.SetBool("RightWalk", false);
            myAnim.SetBool("UpWalk", false);
            myAnim.SetBool("LeftWalk", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
            myAnim.SetBool("LeftWalk", true);
            myAnim.SetBool("DownWalk", false);
            myAnim.SetBool("UpWalk", false);
            myAnim.SetBool("RightWalk", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
            myAnim.SetBool("RightWalk", true);
            myAnim.SetBool("DownWalk", false);
            myAnim.SetBool("UpWalk", false);
            myAnim.SetBool("LeftWalk", false);
        }

        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            myAnim.Play(myAnim.GetCurrentAnimatorClipInfo(0)[0].clip.name, 0, 0 / (float)4);
    }
}
