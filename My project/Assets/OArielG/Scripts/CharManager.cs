using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    private int newCharID = 0;
    public static int charID = 0;
    public void changeRCharID()
    {
        if (newCharID == gameObject.transform.childCount-1)
        {
            newCharID = 0;
        } else
        {
            newCharID += 1;
        }
        charID = newCharID;
        LoadChar();
    }
    public void changeLCharID()
    {
        if (newCharID == 0)
        {
            newCharID = gameObject.transform.childCount-1;
        }
        else
        {
            newCharID -= 1;
        }
        charID = newCharID;
        LoadChar();
    }
    public void LoadChar()
    {
        for (int i = 0; i < gameObject.transform.childCount; i++) 
        {
            if (i == charID)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            } else
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
    private void Start()
    {
        LoadChar();
    }
}
