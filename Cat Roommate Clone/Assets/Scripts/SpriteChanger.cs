using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    
    public Sprite[] spriteList;
    SpriteRenderer Catsr;
    // Start is called before the first frame update
    void Start()
    {
        Catsr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        GoodAnswersSpriteChange();
        BadAnswersSpriteChange();

    }





    void GoodAnswersSpriteChange()
    {
        if (TextChanger.GoodAnswers == 1)
        {
            Catsr.sprite = spriteList[3];
        }
        if (TextChanger.GoodAnswers == 2)
        {
            Catsr.sprite = spriteList[0];
        }
        if (TextChanger.GoodAnswers == 3)
        {
            Catsr.sprite = spriteList[2];
        }
        if (TextChanger.GoodAnswers == 4)
        {
            Catsr.sprite = spriteList[5];
        }
        if(TextChanger.GoodAnswers == 5)
        {
            Catsr.sprite = spriteList[2];
        }
        if(TextChanger.GoodAnswers == 6)
        {
            Catsr.sprite = spriteList[4];
        }
       // if (TextChanger.GoodAnswers > TextChanger.BadAnswers && TextChanger.linearNum > 5)
        {
       //     Catsr.sprite = spriteList[1];
        }
    }
    void BadAnswersSpriteChange()
    {
        if(TextChanger.BadAnswers == 1)
        {
            Catsr.sprite = spriteList[11];
        }
        if(TextChanger.BadAnswers == 2)
        {
            Catsr.sprite = spriteList[2];
        }
        if (TextChanger.BadAnswers == 3)
        {
            Catsr.sprite = spriteList[8];
        }
        if (TextChanger.BadAnswers == 4)
        {
            Catsr.sprite = spriteList[9];
        }
        if (TextChanger.BadAnswers == 5)
        {
            Catsr.sprite = spriteList[11];
        }
        if (TextChanger.BadAnswers == 6)
        {
            Catsr.sprite = spriteList[10];
        }
      //  if (TextChanger.BadAnswers > TextChanger.GoodAnswers && TextChanger.linearNum > 5)
        {
      //      Catsr.sprite = spriteList[7];
        }
    }
}
