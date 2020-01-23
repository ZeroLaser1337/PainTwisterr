using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpItem : MonoBehaviour
{
    public Quest quest;

    public void Start()
    {
        quest = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Item")
        {
            quest.ContinueQuest();

            Destroy(collision.gameObject);
        }
    }
}
