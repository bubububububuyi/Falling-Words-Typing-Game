using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    public GameObject wordPreafb;
    public Transform Parent;

    public WordDisplay SpawnWord()
    {
        Vector3 randPos = new Vector3(Random.Range(-420f, 420f), Random.Range(1050f, 1350f), 0f);
        GameObject wordObj = Instantiate(wordPreafb);
        wordObj.transform.SetParent(Parent);
        wordObj.transform.localPosition = randPos;
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
        return wordDisplay;
    }
}
