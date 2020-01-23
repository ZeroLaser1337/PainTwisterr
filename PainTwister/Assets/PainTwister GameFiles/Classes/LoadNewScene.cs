using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewScene : MonoBehaviour
{
    public UIManager uIManager;
    public Quest quest;
    public DialogueProgress dialogueProgress;

    public void Awake()
    {
        dialogueProgress = GameObject.FindGameObjectWithTag("UIManager").GetComponent<DialogueProgress>();
        quest = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>();
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        uIManager.NewScene();
        quest.NewScene();
        dialogueProgress.NewScene();
        dialogueProgress.Hide();
    }

    public void Start()
    {
        uIManager.NewText();
        quest.NewQuest(quest.storyQuests[quest.listPos]);
    }
}
