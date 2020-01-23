using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("QuestItem"), menuName = "QuestItem/ New Knowledge Quest")]
public class KnowledgeItem : QuestItem
{
    public GameObject item;
    public Vector3 positionToSpawn;

    public int knowledge;

    public override void QuestStart(Quest quest, DialogueProgress d)
    {
        base.QuestStart(quest, d);

        Instantiate(item, positionToSpawn, Quaternion.identity);
    }

    public override void PickUp(Quest quest)
    {
        quest.ContinueQuest();
    }
}
