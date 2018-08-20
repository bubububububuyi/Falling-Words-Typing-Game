using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;

    private int typeIndex;

    WordDisplay wordDisplay;

    public Word(string msg, WordDisplay display, WordManager wordManager)
    {
        word = msg;
        typeIndex = 0;
        wordDisplay = display;
        wordDisplay.SetMsg(msg, wordManager, this);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        wordDisplay.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            wordDisplay.RemoveWord();
        }
        return wordTyped;
    }

}
