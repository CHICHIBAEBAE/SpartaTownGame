using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public GameObject npcPanel;

    public void OnTriggerEnter2D(Collision other)
    {
        npcPanel.SetActive(true);
    }
}
