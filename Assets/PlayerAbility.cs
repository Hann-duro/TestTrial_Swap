using UnityEngine;

public class PlayerAbility : MonoBehaviour
{
    private PlayerFormController form;

    void Start()
    {
        form = GetComponent<PlayerFormController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            UseAbility();
        }
    }

    void UseAbility()
    {
        switch (form.currentType)
        {
            case CharacterType.Wizard:
                Debug.Log("Wizard: open lever");
                break;

            case CharacterType.Rogue:
                Debug.Log("Rogue: spike immunity");
                break;

            case CharacterType.Hero:
                Debug.Log("Hero: attack monsters");
                break;
        }
    }
}