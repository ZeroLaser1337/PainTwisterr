using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject myButtons;
    public Audiodialog audiodialog;
    public DialogueProgress dialogueProgress;

    public void Start()
    {
        dialogueProgress = GameObject.FindGameObjectWithTag("UIManager").GetComponent<DialogueProgress>();
    }

    public void HideButtons(int i)
    {
        if (i == GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>().listPos)
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>().ContinueQuest();
            Debug.Log("Verder");
        }

        dialogueProgress.StartDialogue(audiodialog);

        myButtons.SetActive(false);
    }
}
