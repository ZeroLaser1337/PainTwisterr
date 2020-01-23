using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = ("Teleport"), menuName = "Teleport/ New Teleport To Main")]
public class TeleportForMainHouse : DoorTeleport
{
    public string bad;
    public string good;

    public override void TeleportPlayer(int knowledgeAmount)
    {
        if(knowledgeAmount < 30)
        {
            SceneManager.LoadScene(bad);
        }
        else if(knowledgeAmount >= 30 && knowledgeAmount < 65)
        {
            SceneManager.LoadScene(base.normal);
        }
        else if(knowledgeAmount >= 65)
        {
            SceneManager.LoadScene(good);
        }
    }
}
