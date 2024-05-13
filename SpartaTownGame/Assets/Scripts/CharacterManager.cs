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
                // 여러 시도 결과 애니메이터를 바꿔주면 스프라이트를 굳이 바꿀 필요가없어서 비활성화
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

