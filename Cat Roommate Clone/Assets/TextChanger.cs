using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger: MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] textStuff;
    int linearNum = 0;

    public void ChangeText()
    {
       
        
        linearNum++;

        Debug.Log("Number is " + linearNum);
        text.text = textStuff[(linearNum)];

    }
   
}
