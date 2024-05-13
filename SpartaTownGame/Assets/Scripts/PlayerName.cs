using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : LoginManager
{
    GameManager gameManager;
    
    public TMP_Text name;
    

    void Start()
    {
        // 메인화면에서 입력한 이름을 가져와서 게임에 넣기
        playerName = PlayerPrefs.GetString(userName);
        name.text = playerName; 
    }

    //private void Update()
    //{
    //    gameManager.playerName = PlayerPrefs.GetString(gameManager.userName);
    //    name.text = gameManager.playerName;
    //}

}
