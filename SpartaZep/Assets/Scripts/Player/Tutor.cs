using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tutor : MonoBehaviour
{
    // Start is called before the first frame update
    private string _nameText;

    public GameObject TutorCollisionPopup;
    private void Awake()
    {
        _nameText = transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text;
    }
    void Start()
    {
        GameManager.Instance.AddAttendee(_nameText);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TutorCollisionPopup.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = _nameText;
            TutorCollisionPopup.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        TutorCollisionPopup.SetActive(false);
    }

}
