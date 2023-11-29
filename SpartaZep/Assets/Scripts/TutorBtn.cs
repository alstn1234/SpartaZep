using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorBtn : MonoBehaviour
{
    [SerializeField] private GameObject tutorCollisionPopup;
    [SerializeField] private GameObject tutorCallPopup;
    [SerializeField] private GameObject tutorAnswerPopup;
    [SerializeField] private TMP_Text tutorAnswer;

    public void AnswerBtnClick()
    {
        tutorCollisionPopup.SetActive(false);
        tutorCallPopup.SetActive(true);
    }

    public void StartChatBtnClick()
    {
        tutorCallPopup.SetActive(false);
        tutorAnswerPopup.SetActive(true);

        List<string> answer = new List<string>{
            "������ ���� �ٺ��� ���� ���޽��ϴ�. ������ ������.",
            "�������Դϴ�.",
            "�����Ͻñ� ���� ȥ�� ����غ��̳���??",
        };

        int randomNum = Random.Range(0, answer.Count);
        string tutorAnswers = answer[randomNum];

        tutorAnswer.text = tutorAnswers;
    }

    public void TutorAnswerOkBtnClick()
    {
        tutorAnswerPopup.SetActive(false);
    }

}
