using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBtn : MonoBehaviour
{
    [SerializeField] private GameObject AttendeeListPopup;
    [SerializeField] private GameObject ChangeCharacterPopup;
    [SerializeField] private GameObject ChangeNamePopup;

    public void AttendeeListBtnClick()
    {
        AttendeeListPopup.SetActive(true);
    }

    public void OutAttendeeListBtnClick()
    {
        AttendeeListPopup.SetActive(false);
    }

    public void ChangeCharacterBtnClick()
    {
        if(ChangeCharacterPopup.activeSelf)
            ChangeCharacterPopup.SetActive(false);
        else
            ChangeCharacterPopup.SetActive(true);
    }

    public void ChangeNameBtnClick()
    {
        if (ChangeNamePopup.activeSelf)
            ChangeNamePopup.SetActive(false);
        else
            ChangeNamePopup.SetActive(true);
    }
}
