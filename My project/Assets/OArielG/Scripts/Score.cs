using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score: MonoBehaviour
{
    TextMeshProUGUI texto;
    public static int score;
    private void Start()
    {
        score = 0;
        texto = gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        texto.text = string.Format("X {0}", score);
    }
}
