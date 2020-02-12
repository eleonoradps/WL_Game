using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    [SerializeField] TMP_InputField userInput;
    string userWord;

    string goodWord;

    [SerializeField] RandomWord randomWord;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            userWord = userInput.text;
            goodWord = randomWord.ReturnWord();
            userInput.text = null;
            checkWords();
        }
    }

    void checkWords()
    {
        if (userWord == goodWord)
        {
            Debug.Log("WIN");
        }

        else
        {
            Debug.Log("WRONG WORD");
        }
    }
}
