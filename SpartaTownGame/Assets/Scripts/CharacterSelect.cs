using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Charater
{
    ANGEL = 1,
    DEMON,
    KNIGHT

}
public class CharacterSelect : MonoBehaviour
{
    public GameObject characterSelect;
    public GameObject characterPanal;
    Image image;
    public void Start()
    {
        image = GetComponent<Image>();

    }

    public void SelectPanalOn()
    {
        // 캐릭터 선택 창
        characterPanal.SetActive(true);
    }

    public void SelectAngel()
    {
        // 천사 선택 시에 캐릭터패널을 다시 내리고 캐릭터 선택 버튼을 천사로 바꾼다. 그리고 캐릭터값 벨류에 1을 보냄
        PlayerPrefs.SetInt("character", 1);
        characterPanal.SetActive(false);
        characterSelect.GetComponent<Image>().sprite = Resources.Load<Sprite>("angel_idle_anim_f0 1");
    }
    public void SelectDemon() 
    {
        PlayerPrefs.SetInt("character", 2);
        characterPanal.SetActive(false);
        characterSelect.GetComponent<Image>().sprite = Resources.Load<Sprite>("big_demon_idle_anim_f0 1");
    }
    public void SelectKnight()
    {
        PlayerPrefs.SetInt("character", 3);
        characterPanal.SetActive(false);
        characterSelect.GetComponent<Image>().sprite = Resources.Load<Sprite>("knight_f_idle_anim_f0 1");
    }
}
