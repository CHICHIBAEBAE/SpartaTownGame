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
        // ĳ���� ���� â
        characterPanal.SetActive(true);
    }

    public void SelectAngel()
    {
        // õ�� ���� �ÿ� ĳ�����г��� �ٽ� ������ ĳ���� ���� ��ư�� õ��� �ٲ۴�. �׸��� ĳ���Ͱ� ������ 1�� ����
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
