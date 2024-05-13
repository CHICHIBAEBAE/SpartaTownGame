using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCManager : MonoBehaviour
{
    public GameObject npcPanel;

    public void OnTriggerEnter2D(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            npcPanel.SetActive(true);
        }
            
    }
}
