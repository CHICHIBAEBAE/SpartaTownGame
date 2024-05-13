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

    public void RenameBtn()
    {
        renamePanal.SetActive(true);
    }

    public void Rename()
    {
        playerName = inputField_ReName.GetComponent<TMP_InputField>().text;
        PlayerPrefs.SetString(userName, playerName);

        bool click = true;

        while (click)
        {
            //�÷��̾� �̸��� 2~10���ڰ� �ƴҰ�� ���޽��� ���
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

    public void CharacterChoiceBtn()
    {
        characterPanel.SetActive(true);
    }

  
}
