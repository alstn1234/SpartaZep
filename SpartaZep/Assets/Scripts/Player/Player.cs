using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("CharacterPrefabs")]
    [SerializeField] private GameObject pinkslime;
    [SerializeField] private GameObject orangeslime;

    [Header("PlayerData")]
    [SerializeField] private TMP_Text playerNameText;

    private void Start()
    {
        ChangePlayerData();
        PlayerData.Instance.ChangeData += ChangePlayerData;
    }

    public void ChangePlayerData()
    {
        switch (PlayerData.Instance.characterName)
        {
            case CharacterName.Pinkslime:
                pinkslime.SetActive(true);
                orangeslime.SetActive(false);
                break;
            case CharacterName.Orangeslime:
                pinkslime.SetActive(false);
                orangeslime.SetActive(true);
                break;
        }
        playerNameText.text = PlayerData.Instance.playerName;
    }
}
