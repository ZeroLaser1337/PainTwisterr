using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = ("QuestItem"), menuName = "QuestItem/ New Audio Quest")]
public class AudioQuest : QuestItem
{
    public Audiodialog audiodialog;

    public override void QuestStart(Quest quest, DialogueProgress d)
    {
        Debug.Log("Talking");
        d.StartDialogue(audiodialog);
    }
}
