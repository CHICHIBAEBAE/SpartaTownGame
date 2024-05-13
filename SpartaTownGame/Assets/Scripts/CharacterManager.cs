using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private int playerCharacter;
    public GameObject mainSprite;

    public void Update()
    {
        PlayerCharacterChoice();
    }
    public void PlayerCharacterChoice()
    {
        playerCharacter = PlayerPrefs.GetInt("character");
        var resourceName = "Animator Override Controller/Player0" + playerCharacter.ToString();
        var animator = mainSprite.GetComponent<Animator>();

        switch (playerCharacter)
        {
            case 1:
                //mainSprite.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("angel_idle_anim_f0 1");
                // ���� �õ� ��� �ִϸ����͸� �ٲ��ָ� ��������Ʈ�� ���� �ٲ� �ʿ䰡��� ��Ȱ��ȭ
                animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load(resourceName);
                //Debug.Log(resourceName);
                break;
            case 2:
                animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load(resourceName);
                break;
            case 3:
                animator.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load(resourceName);
                break;
        }
    }
}

