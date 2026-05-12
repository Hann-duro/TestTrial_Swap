using UnityEngine;

public enum CharacterType
{
    Hero,
    Wizard,
    Rogue
}

public class PlayerFormController : MonoBehaviour
{
    public CharacterType currentType;

    public Sprite heroSprite;
    public Sprite wizardSprite;
    public Sprite rogueSprite;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ChangeForm(CharacterType.Hero);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            ChangeForm(CharacterType.Hero);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            ChangeForm(CharacterType.Wizard);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            ChangeForm(CharacterType.Rogue);
    }

    void ChangeForm(CharacterType newType)
    {
        currentType = newType;

        switch (newType)
        {
            case CharacterType.Hero:
                sr.sprite = heroSprite;
                break;

            case CharacterType.Wizard:
                sr.sprite = wizardSprite;
                break;

            case CharacterType.Rogue:
                sr.sprite = rogueSprite;
                break;
        }
    }
}