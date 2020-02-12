using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsManager : MonoBehaviour
{
    
    private Color currentColor = Color.white;
    public Color CurrentColor
    {
        get { return currentColor; }
        set { currentColor= Color.white; }
    }

//    void Update()
//    {
//        
//    }

    public void  SetRedColor()
    {
        currentColor = Color.red;
    }
    
    public void SetYellowColor()
    {
        currentColor = Color.yellow;
    }
    
    public void  SetBlueColor()
    {
        currentColor = Color.blue;
    }
    
    public void SetGreenColor()
    {
        currentColor = Color.green;
    }
    
}
