using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Dialogue List")]
public class Audiodialog : ScriptableObject
{
    public List<AudioClip> audioClips;
    public List<string> myStrings;
    public List <float> myTimer;
    public bool question;
    public bool fourButtons;
}

