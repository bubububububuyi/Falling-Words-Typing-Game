using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager WordManager;

    // Use this for initialization
    void Start()
    {
		
    }
	
    // Update is called once per frame
    void Update()
    {
        foreach (char letter in Input.inputString)
        {
//            Debug.LogError(letter);
            WordManager.TypeLetter(letter);
        }
    }
}
