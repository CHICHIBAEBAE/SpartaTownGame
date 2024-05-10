using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : LoginManager
{
    
    
    public TMP_Text name;
    

    void Start()
    {
        playerName = PlayerPrefs.GetString(userName);
        name.text = playerName; 
    }

}
