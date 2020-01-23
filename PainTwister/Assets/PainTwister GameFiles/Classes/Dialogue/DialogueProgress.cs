using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueProgress : MonoBehaviour
{
    public Quest quest;
    public Audiodialog audiodialog;

    public AudioSource audioSource;

    public GameObject twoButtons;
    public GameObject fourButtons;

    public float timer;

    public int listPosCurrentDialogue;

    public bool conversating;
    public bool startConvo;

    public void StartDialogue(Audiodialog a)
    {
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

            if (Input.GetButtonDown("Fire1"))
            {
                if(i < (a.myStrings.Count - 1))
                {
                    listPosCurrentDialogue++;
                    quest.uI.NewText();
                    MusicPlayer(a, listPosCurrentDialogue);
                    timer = a.myTimer[listPosCurrentDialogue];
                }
                else if(i >= (a.myStrings.Count - 1) && a.question == true)
                {
                    conversating = false;

                    if (a.fourButtons)
                    {
                        fourButtons.SetActive(true);
                    }
                    else
                    {
                        twoButtons.SetActive(true);
                    }
                }
                else
                {
                    conversating = false;

                    if (i == quest.listPos)
                    {
                        quest.ContinueQuest();
                    }
                }
            }
        }
    }

    public void MusicPlayer(Audiodialog a, int i)
    {
        audioSource.clip = a.audioClips[i];
        audioSource.Play();
    }

    public void NewScene()
    {
        audioSource = GameObject.FindGameObjectWithTag("GameManager").GetComponent<AudioSource>();
        quest = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Quest>();
        twoButtons = GameObject.FindGameObjectWithTag("TwoButtons");
        fourButtons = GameObject.FindGameObjectWithTag("FourButtons");
    }

    public void Hide()
    {
        twoButtons.SetActive(false);
        fourButtons.SetActive(false);
    }
}
