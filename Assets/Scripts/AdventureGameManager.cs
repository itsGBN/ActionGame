using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class AdventureGameManager : MonoBehaviour
{
    public GameObject textBox;
    public GameObject player;
    public GameObject text;
    TMP_Text myText;


    private void Start()
    {
        myText = text.GetComponent<TMP_Text>();
    }

    public void TriggerConvo(string dialogue)
    {
        textBox.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5f, player.transform.position.z);
        textBox.SetActive(true);
        text.SetActive(true);
        Debug.Log(dialogue);
        myText.text = dialogue;
    }

    public void StopConvo()
    {
        textBox.SetActive(false);
        text.SetActive(false);

    }
}
