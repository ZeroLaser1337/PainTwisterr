using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueProgress : MonoBehaviour
{
    public Audiodialog audiodialog;
    protected ConversationSystem conversationSystem;
    protected QuestManager questManager;
    public AudioSource audioSource;
    public float timer;
    public int listPosCurrentDialogue;
    public bool conversating;
    public bool startConvo;

    //public Animator anim;

    public void StartDialogue(Audiodialog a)
    {
        conversationSystem = GetComponent<ConversationSystem>();
        //questManager = GameObject.Find("Quest Manager").GetComponent<QuestManager>();
        conversating = true;
        startConvo = true;

        audiodialog = a;
    }

    public void ProgressDialogue(Audiodialog a, int i)
    {
        timer -= Time.deltaTime;

        if (startConvo == true)
        {
            MusicPlayer(a, i);
            startConvo = false;
            timer = a.myTimer[i];
        }

        if (timer <= 0)
        {
            
            timer = 0;
            //anim.SetBool("PlayAnim", false);

            if (Input.GetButtonDown("Fire1"))
            {
                if(i < (a.myStrings.Count - 1))
                {
                    //conversationSystem.show4Buttons = false;
                    listPosCurrentDialogue++;
                    MusicPlayer(a, listPosCurrentDialogue);
                    timer = a.myTimer[listPosCurrentDialogue];
                }
                else if(i >= (a.myStrings.Count - 1) && a.question == true)
                {
                    conversationSystem.show4Buttons = true;   
                    Debug.Log("BUTTONS");
                    conversating = false;
                }
                else
                {
                    if(a.questBool == true)
                    {
                        questManager.UpdateQuest(a.quest, a.questAmount);
                    }
                    
                    conversating = false;
                }
            }
        }
        else if (timer >= 0)
        {
            //anim.SetBool("PlayAnim", true);
        }
    }

    public void MusicPlayer(Audiodialog a, int i)
    {
        audioSource.clip = a.audioClips[i];
        audioSource.Play();
    }
}
