using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCConvo : MonoBehaviour
{
    public string myDialogue;
    public string myNextDialogue;
    public GameObject playerObject;
    public GameObject npcObject;
    public GameObject gameManager;
    AdventureGameManager myScript;
    AdventurePlayer myScript2;

    public AudioSource audioSource;
    public AudioClip audioclip;

    private void Start()
    {
        myScript = gameManager.GetComponent<AdventureGameManager>();
        myScript2 = playerObject.GetComponent<AdventurePlayer>();
    }

    private void Update()
    {
        if(Vector3.Distance(playerObject.transform.position, npcObject.transform.position) < 0.3f && Input.GetKey(KeyCode.Space) && myScript2.hasKey != true)
        {
            myScript.TriggerConvo(myDialogue);
        }

        if (Vector3.Distance(playerObject.transform.position, npcObject.transform.position) < 0.3f && Input.GetKeyDown(KeyCode.Space) && myScript2.hasKey != true)
        {
            audioSource.PlayOneShot(audioclip);
        }

        if (Vector3.Distance(playerObject.transform.position, npcObject.transform.position) < 0.3f && Input.GetKey(KeyCode.Space) && myScript2.hasKey == true)
        {
            myScript.TriggerConvo(myNextDialogue);
        }

        if (Vector3.Distance(playerObject.transform.position, npcObject.transform.position) < 0.3f && Input.GetKeyDown(KeyCode.Space) && myScript2.hasKey == true)
        {
            audioSource.PlayOneShot(audioclip);
        }

        if (Vector3.Distance(playerObject.transform.position, npcObject.transform.position) > 0.5f && Vector3.Distance(playerObject.transform.position, npcObject.transform.position) < 0.6f)
        {
            myScript.StopConvo();
        }

        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;
    }

}
