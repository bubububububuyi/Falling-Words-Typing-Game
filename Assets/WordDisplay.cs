using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{

    public Text MsgText;

    private float Speed = 100f;

    WordManager WordManager;

    bool IsActivey;

    Word Word;

    public void SetMsg(string msg, WordManager wordManager, Word word)
    {
        MsgText.text = msg;
        WordManager = wordManager;
        IsActivey = false;
        Word = word;
    }

    public void RemoveLetter()
    {
        MsgText.text = MsgText.text.Remove(0, 1);
        MsgText.color = Color.red;
        IsActivey = true;
    }

    public void RemoveWord()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {
        transform.Translate(0f, -Speed * Time.deltaTime, 0f);

        if (transform.position.y < 0)
        {
            WordManager.RemoveWord(Word, IsActivey);
            RemoveWord();
        }
    }
}
