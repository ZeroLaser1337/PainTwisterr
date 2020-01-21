using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FakeUIManager : MonoBehaviour
{
    public DialogueProgress dialogueProgress;

    public Text mainText;
    public Text timer;

    public Audiodialog audiodialog;

    public void Start()
    {
        dialogueProgress.StartDialogue(audiodialog);
    }

    public void Update()
    {
        timer.text = dialogueProgress.timer.ToString();

        if (dialogueProgress.conversating)
        {
            dialogueProgress.ProgressDialogue(dialogueProgress.audiodialog, dialogueProgress.listPosCurrentDialogue);
            mainText.text = dialogueProgress.audiodialog.myStrings[dialogueProgress.listPosCurrentDialogue];
        }
        else
        {
            dialogueProgress.listPosCurrentDialogue = 0;
            mainText.text = null;
        }
    }
}
