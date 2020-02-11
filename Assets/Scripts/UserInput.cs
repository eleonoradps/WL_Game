using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    [SerializeField] TMP_InputField userInput;
    string userWord;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            userWord = userInput.text;
            Debug.Log(userWord);
            userInput.text = null;
        }
        
    }
}
