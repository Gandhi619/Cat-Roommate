using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger: MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] textStuff;
    int linearNum = 0;
    bool wasRightClicked;
    bool wasLeftClicked;
    public static int GoodAnswers = 0;
    public static int BadAnswers = 0;

    public void RightClicked()
    {
        wasRightClicked = true;
        wasLeftClicked = false;
        
        if(wasRightClicked == true)
        {
            
            GoodAnswers++;
            Debug.Log("GoodAnswer is" + GoodAnswers);
        }
    }
    public void LeftClicked()
    {
        wasLeftClicked = true;
        wasRightClicked = false;
        
        if(wasLeftClicked == true)
        {
            BadAnswers++;
            Debug.Log("BadAnswer is" + BadAnswers);
        }
    }


    public void ChangeText()
    {
       
        
        linearNum++;

        Debug.Log("Number is " + linearNum);
        text.text = textStuff[(linearNum)];

    }
   
}
