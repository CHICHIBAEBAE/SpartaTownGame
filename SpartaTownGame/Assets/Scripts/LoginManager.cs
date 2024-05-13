using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{

    [SerializeField] private GameObject errorMessage;

    [SerializeField] private TMP_InputField inputField_Name;
    public string playerName;
    public string userName;

    public void JoinBtn()
    {
        playerName = inputField_Name.GetComponent<TMP_InputField>().text;
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
            else // 아닐 경우 접속
            {
                SceneManager.LoadScene("MainScene");
                click = false;
                break;
            }

        }
    }
    public void DownError()
    {
        errorMessage.SetActive(false);
    }
}
