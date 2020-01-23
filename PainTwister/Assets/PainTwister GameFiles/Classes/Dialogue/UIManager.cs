using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public DialogueProgress dialogueProgress;

    public Text mainText;
    public Text questText;
    public Text timer;

    public void Update()
    {
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

    public void NewText()
    {
        questText.text = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>().storyQuests[GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>().listPos].questText;
        mainText.text = questText.text;
    }

    public void NewScene()
    {
        mainText = GameObject.FindGameObjectWithTag("Dialogue").GetComponent<Text>();
        questText = GameObject.FindGameObjectWithTag("QuestText").GetComponent<Text>();
    }
}
