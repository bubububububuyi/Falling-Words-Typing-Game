using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    public static string[] wordLists =
    { 
        "dajiahao", "woshinimen", "nimenqichuanglemei", 
        "buhaochi", "jinwanjidian", "kelonghenyouqu", 
        "yiqilaiwana", "jibaqin", "jibaguo", 
        "daqiuqule", "chishibani", "shuijiaoba"
    };

    public static string GetRandomword()
    {
        return wordLists[Random.Range(0, wordLists.Length)];
    }

}
