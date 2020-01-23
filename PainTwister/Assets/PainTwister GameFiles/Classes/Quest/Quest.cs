using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public List<QuestItem> storyQuests;
    public DialogueProgress dialogueProgress;
    public UIManager uI;

    private RaycastHit hit;

    public Text myQuestText;

    public int listPos;

    public bool gameCompleted;

    public void Start()
    {
        NewQuest(storyQuests[listPos]);

        DontDestroyOnLoad(this);
    }

    public void NewScene()
    {
        myQuestText = GameObject.FindGameObjectWithTag("QuestText").GetComponent<Text>();
        dialogueProgress = GameObject.FindGameObjectWithTag("UIManager").GetComponent<DialogueProgress>();
        uI = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    public void NewQuest(QuestItem item)
    {
        item.QuestStart(this, dialogueProgress);

        newText(storyQuests[listPos]);
    }
    
    public void ContinueQuest()
    {
        if (listPos < storyQuests.Count - 1)
        {
            listPos++;

            uI.NewText();

            NewQuest(storyQuests[listPos]);
        }
        else gameCompleted = true;
    }

    public void newText(QuestItem item)
    {
        myQuestText.text = item.questText;
    }
}
