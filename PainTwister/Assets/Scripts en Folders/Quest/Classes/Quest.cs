using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quest : MonoBehaviour
{
    public KnowledgeMeter knowledgeMeter;
    public ListProgression progression;
    public List<QuestItem> storyQuests;

    public GameObject itemsSpawned;
    public GameObject gameOverGO;
    public GameObject player;

    public TextMeshProUGUI myQuestText;

    public int listPos;

    public void Start()
    {
        NewQuest(storyQuests[listPos]);

        //GameCompleted(false);
    }

    public void Update()
    {
        myQuestText.text = storyQuests[listPos].questText;
        progression = GameObject.FindGameObjectWithTag("QuestProgress").GetComponent<ListProgression>();
    }

    //public void OnCollisionEnter(Collision c)
    //{
    //    if(c.collider.gameObject.tag == "Item")
    //    {
    //        if(storyQuests[listPos].questItemNum == c.collider.gameObject.GetComponent<QuestItemNumber>().questNumber)
    //        {
    //            storyQuests[listPos].PickUp(this);

    //            Destroy(c.collider.gameObject);
    //        }
    //    }
    //}

    public void NewQuest(QuestItem item)
    {
        item.QuestStart(this, itemsSpawned.transform);

        //newText(storyQuests[listPos]);

        //put 4 button bool equal to storyQuests[listPos}.fourButtons
    }

    public void ContinueQuest(QuestItem item)
    {
        if (listPos < storyQuests.Count - 1)
        {
            progression.listPos++;

            NewQuest(storyQuests[listPos]);
        }
        else
        {
            //GameCompleted(true);
        }
    }

    public void newText(QuestItem item)
    {
        myQuestText.text = item.questText;
    }

    //public void GameCompleted(bool done)
    //{
     //   gameOverGO.SetActive(done);
    //}
}
