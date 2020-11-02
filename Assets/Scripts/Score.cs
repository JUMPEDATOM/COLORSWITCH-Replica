using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreTxt;

    // Update is called once per frame
    void Update()
    {
      scoreTxt.text = score.ToString();    
    }
}
