using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public int knowledgeAmount;

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Door")
        {
            for(int i = 0; i < collision.gameObject.GetComponent<DoorScriptHolder>().doorTeleport.quests.Count; i++)
            {
                if(collision.gameObject.GetComponent<DoorScriptHolder>().doorTeleport.quests[i] == GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>().listPos)
                {
                    GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>().ContinueQuest();
                    break;
                }
            }
            collision.gameObject.GetComponent<DoorScriptHolder>().doorTeleport.TeleportPlayer(knowledgeAmount);
        }
    }
}
