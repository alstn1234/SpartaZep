using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    private List<string> _attendeeList = new List<string>();

    public GameObject attendeeListPos;
    public TMP_Text attendeeText;
    public TMP_Text timeText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        timeText.text = DateTime.Now.ToString("tt HH: mm: ss");
    }

    public void AddAttendee(string name)
    {
        _attendeeList.Add(name);
        TMP_Text nameText = Instantiate(attendeeText, attendeeListPos.transform);
        nameText.text = name;
        PrintAttendee();
    }

    public void RemoveAttendee(string name)
    {
        _attendeeList.Remove(name);
    }

    public void PrintAttendee()
    {
        foreach(Transform child in attendeeListPos.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (string attendee in _attendeeList)
        {
            TMP_Text nameText = Instantiate(attendeeText, attendeeListPos.transform);
            nameText.text = attendee;
        }
    }
}
