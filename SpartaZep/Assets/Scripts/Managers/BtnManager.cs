using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnManager : MonoBehaviour
{
    private float _speed = 5.0f;
    [Header("Character")]
    [SerializeField] private Image characterImage;

    [Header("Popup")]
    [SerializeField] private GameObject characterChoicePopup;
    [SerializeField] private GameObject characterInfoPopup;

    [Header("Data")]
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private PlayerSO playerSO;

    public void Choice()
    {
        characterImage.sprite = this.gameObject.GetComponent<Image>().sprite;
        characterInfoPopup.SetActive(true);
    }

    public void ChoicePinkslime()
    {
        pickPinkslime();
        Choice();
    }

    public void ChoiceOrangeslime()
    {
        pickOrangeslime();
        Choice();
    }

    public void pickPinkslime()
    {
        PlayerData.Instance.characterName = CharacterName.Pinkslime;
        characterChoicePopup.SetActive(false);
    }

    public void pickOrangeslime()
    {
        PlayerData.Instance.characterName = CharacterName.Orangeslime;
        characterChoicePopup.SetActive(false);
    }

    public void ChoiceAgain()
    {
        characterChoicePopup.SetActive(true);
        characterInfoPopup.SetActive(false);
    }
    public void ConfirmBtnClick()
    {
        var textLength = nameText.text.Length - 1;
        if (textLength >= 2 && textLength <= 10)
        {
            PlayerData.Instance.playerName = nameText.text;
            PlayerData.Instance.speed = _speed;

            SceneManagement.Instance.LoadMainScene();

        }
    }

    public void ChangeName()
    {
        var textLength = nameText.text.Length - 1;
        if (textLength >= 2 && textLength <= 10)
        {
            PlayerData.Instance.playerName = nameText.text;
            characterInfoPopup.SetActive(false);
        }
    }
}
