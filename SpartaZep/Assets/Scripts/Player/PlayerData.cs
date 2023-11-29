using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData Instance = null;

    [SerializeField] private PlayerSO playerSO;

    public event Action ChangeData;
    public float speed 
    {
        get { return playerSO.speed; }
        set
        {
            playerSO.speed = value;
            CallChangeData();
        }
    }
    public string playerName 
    {
        get { return playerSO.playerName; }
        set
        {
            playerSO.playerName = value;
            CallChangeData();

        }
    }
    public CharacterName characterName
    {
        get { return playerSO.characterName; }
        set
        {
            playerSO.characterName = value;
            CallChangeData();

        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CallChangeData()
    {
        ChangeData?.Invoke();
    }
}
