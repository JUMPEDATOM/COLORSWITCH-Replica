using UnityEngine;
using UnityEngine.UI;


public class HighScore : MonoBehaviour
{
    public Text HighScoreTxt;
    public Text ScoreTxt;
    
    void Start()
    {
      HighScoreTxt.text = PlayerPrefs.GetInt("High Score",0).ToString();
    }
    
    void Update()
    {
      ScoreTxt.text = Score.score.ToString();    
      if (Score.score > PlayerPrefs.GetInt("High Score",0))
      {
        PlayerPrefs.SetInt("High Score", Score.score);
        HighScoreTxt.text = Score.score.ToString();
      }
    }
}
