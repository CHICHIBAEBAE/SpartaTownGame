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
        // ����ȭ�鿡�� �Է��� �̸��� �����ͼ� ���ӿ� �ֱ�
        playerName = PlayerPrefs.GetString(userName);
        name.text = playerName; 
    }

    //private void Update()
    //{
    //    gameManager.playerName = PlayerPrefs.GetString(gameManager.userName);
    //    name.text = gameManager.playerName;
    //}

}
