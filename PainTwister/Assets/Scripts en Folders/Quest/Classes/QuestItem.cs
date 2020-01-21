using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("Quest"), menuName = "Quest/New Quest")]
public class QuestItem : ScriptableObject
{
    public int questItemNum;

    public string questText;

    public bool fourButtons;

    public virtual void QuestStart(Quest quest, Transform parent)
    {
        Debug.Log("Spawned");

        quest.myQuestText.text = questText;
    }

    public virtual void PickUp(Quest quest)
    {
        Debug.Log("Picked Up");

        quest.ContinueQuest(this);
    }
}
