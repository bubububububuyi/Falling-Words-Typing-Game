using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{

    public WordManager WordManager;

    private float wordDelay = 1.5f;
    private float nextWordTime = 0f;

    // Use this for initialization
    void Start()
    {
		
    }
	
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextWordTime)
        {
            WordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= 0.99f;
        }
    }
}
