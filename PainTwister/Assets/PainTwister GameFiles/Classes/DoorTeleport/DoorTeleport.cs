using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = ("Teleport"), menuName = "Teleport/ New Teleport To ElseWhere")]
public class DoorTeleport : ScriptableObject
{
    public List<int> quests;
    public string normal;

    public virtual void TeleportPlayer(int knowledgeAmount)
    {
        SceneManager.LoadScene(normal);
    }
}
