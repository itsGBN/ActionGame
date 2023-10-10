using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public AudioSource audioSource5;
    public AudioClip audioClip5;

    // Start is called before the first frame update
    void Start()
    {
        audioSource5.PlayOneShot(audioClip5);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)) { SceneManager.LoadScene("AdventureGame"); } 
    }
}
