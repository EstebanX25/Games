using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{
    private const bool V = false;

    public void Exit()
    {
        //UnityEditor.EditorApplication.isPlaying = V;
        Application.Quit();
    }
}
