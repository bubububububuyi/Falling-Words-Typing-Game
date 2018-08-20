using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{

    public List<Word> WordLists;
    public WordSpawner WordSpawner;

    private bool hasActiveWord;
    private Word activeWord;


    // Use this for initialization
    void Start()
    {
    }
	
    // Update is called once per frame
    void Update()
    {
		
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomword(), WordSpawner.SpawnWord(),this);
        WordLists.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach (Word word in WordLists)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            WordLists.Remove(activeWord);
        }
    }

    public void RemoveWord(Word word, bool isRest = false)
    {
        if (isRest)
        {
            hasActiveWord = false;
        }
        WordLists.Remove(word);
    }

}
