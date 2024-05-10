using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{

    public GameObject ErrorMessage;

    public TMP_InputField inputField_Name;
    public string playerName;
    public string userName;

    public void JoinBtn()
    {
        playerName = inputField_Name.GetComponent<TMP_InputField>().text;
        PlayerPrefs.SetString(userName, playerName);

        bool click = true;

        while (click)
        {
          //�÷��̾� �̸��� 2~10���ڰ� �ƴҰ�� ���޽��� ���
            if (playerName.Length > 10 || playerName.Length < 2)
            {
                ErrorMessage.SetActive(true);
                click = false;
                Invoke("DownError", 3);

            }
            else // �ƴ� ��� ����
            {
                SceneManager.LoadScene("MainScene");
                click = false;
                break;
            }

        }
    }
    public void DownError()
    {
        ErrorMessage.SetActive(false);
    }

              


        

}
