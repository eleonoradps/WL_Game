using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] GameObject p1Panel;
    [SerializeField] GameObject p2Panel;
    [SerializeField] GameObject losePanel;

    [SerializeField] TextMeshProUGUI timerText;
    const float oneSecond = 1.0f;
    float floatTimer = 30.0f;
    int timer = 30;
    const float restartFloatTimer = 30.0f;
    const int restartTimer = 30;
    [SerializeField] float timeBeforeStop;

    bool p1Turn = true;
    bool p2Turn = false;
    
    void Update()
    {
        if (p1Turn || p2Turn)
        {
            floatTimer -= oneSecond * Time.deltaTime;
            timer = (int)floatTimer;
            timerText.text = timer.ToString();
        }
        

        if (timer <= 0 && p1Turn)
        {
            p1Panel.SetActive(true);
            p2Panel.SetActive(false);
            floatTimer = restartFloatTimer;
            timer = restartTimer;
            p1Turn = false;
            p2Turn = true;
        }

        if (timer <= 0 && p2Turn)
        {
            p1Turn = false;
            p2Turn = true;
            p1Panel.SetActive(false);
            p2Panel.SetActive(false);
            losePanel.SetActive(true);
        }
    }
}
