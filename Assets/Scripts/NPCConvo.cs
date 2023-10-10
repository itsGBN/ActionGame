using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCConvo : MonoBehaviour
{
    public string myDialogue;
    public GameObject playerObject;
    public GameObject npcObject;
    public GameObject gameManager;
    AdventureGameManager myScript;

    private void Start()
    {
        myScript = gameManager.GetComponent<AdventureGameManager>();
    }

    private void Update()
    {
        if(Vector3.Distance(playerObject.transform.position, npcObject.transform.position) < 0.2f && Input.GetKey(KeyCode.Space))
        {
            myScript.TriggerConvo(myDialogue);
        }
        if (Vector3.Distance(playerObject.transform.position, npcObject.transform.position) > 0.3f)
        {
            myScript.StopConvo();
        }

        GetComponent<SpriteRenderer>().sortingOrder = Mathf.RoundToInt(transform.position.y * 100f) * -1;
    }

}
