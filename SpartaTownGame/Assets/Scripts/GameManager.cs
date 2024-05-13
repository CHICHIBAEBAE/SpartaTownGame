using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net.Http;

public class GameManager : MonoBehaviour
{

    LoginManager loginManager;
    

    [SerializeField] private GameObject errorMessage;
    [SerializeField] private TMP_Text timeTxt;
    [SerializeField] private GameObject renamePanal;
    [SerializeField] private TMP_InputField inputField_ReName;
    public GameObject characterPanel;
    public GameObject participantPanel;

    public string playerName;
    public string userName;
    public TMP_Text name;


    void Update()
    {
        NowTimeText();
        
    }

    public void NowTimeText()
    {
        timeTxt.text = DateTime.Now.ToString(("HH:mm"));
    }

   

    public void Rename()
    {
        // 원래 PlayerName 클래스에 Update 메서드 안에서 진행했는데 그렇게 하니 적용이 안됐다.
        // 근데 게임을 종료했다가 다시 키면 전에 썼던 이름이 이제서야 바뀌는걸 보고 업데이트에 있으면 안된다고 판단.
        // 버튼을 누르는 시점에 변경되도록 GameManager로 옮김
        playerName = inputField_ReName.GetComponent<TMP_InputField>().text;
        PlayerPrefs.SetString(userName, playerName);

        bool click = true;

        while (click)
        {
            //플레이어 이름이 2~10글자가 아닐경우 경고메시지 출력
            if (playerName.Length > 10 || playerName.Length < 2)
            {
                errorMessage.SetActive(true);
                click = false;
                Invoke("DownError", 3);
            }
            else
            {
                playerName = PlayerPrefs.GetString(userName);
                name.text = playerName;

                renamePanal.SetActive(false);
                click = false;
                break;
            }

        }
    }

    

    public void RenameBtn()
    {
        renamePanal.SetActive(true);
    }

    public void CharacterChoiceBtn()
    {
        characterPanel.SetActive(true);
    }

    public void ParticipantBtn()
    {
        participantPanel.SetActive(true);
    }

    public void XBtn()
    {
        participantPanel.SetActive(false);
    }
}
