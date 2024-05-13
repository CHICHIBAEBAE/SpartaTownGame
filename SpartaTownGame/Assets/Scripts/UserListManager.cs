using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserListManager : MonoBehaviour
{
    List<string> User = new List<string>();

    public TMP_Text userListTxt;
    public TMP_Text userName;
     

    public UserListManager()
    {
        User.Add(userName.text);
        User.Add("NPC");
    }
    void Start()
    {
        UserListMake();
    }

    public void UserListMake()
    {
        // 리스트에 있는 User목록을 위치에 맞게 복사
        for (int i = 0; i <= User.Count; i++)
        {
            var list = Instantiate(userListTxt, transform);
            var x = -40;
            var y = 400 - (i * 50);

            list.rectTransform.position = new Vector2(x, y);
            foreach(string userName in User)
            {
                userListTxt.text = userName;
                break;
            }
        }
    }
}
