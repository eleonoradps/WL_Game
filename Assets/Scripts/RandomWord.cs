using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomWord : MonoBehaviour
{
    [SerializeField]
    private List<string> words = new List<string>();

    int wordIndex;
    
    
    [SerializeField] TextMeshProUGUI wordText;
    
    void Start()
    {
        wordIndex = Random.Range (0,(words.Count));
        wordText.text = words[wordIndex];
    }

    public string ReturnWord()
    {
        return words[wordIndex];
    }
}