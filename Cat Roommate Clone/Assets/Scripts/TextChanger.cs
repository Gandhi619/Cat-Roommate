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
    bool isEnd;
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
    private void Update()
    {
        GoodEnd();
        BadEnd();
    }
    public void GoodEnd()
    {
        if (GoodAnswers > BadAnswers &&  linearNum > 5)
        {
            text.text = textStuff[7];
        }
    }
    public void BadEnd()
    {
        if(BadAnswers > GoodAnswers && linearNum > 5) 
        {
            text.text = textStuff[6];
        }
    }
    public void ChangeText()
    {
       
        
        linearNum++;
        //linearNum = Mathf.Clamp(linearNum, 0, 6);

        Debug.Log("Number is " + linearNum);
        text.text = textStuff[(linearNum)];
        if (linearNum == 6)
       {
           isEnd = true;

       }

    }
   
}
