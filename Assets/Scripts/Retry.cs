using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void RetryButton()
    {
      FindObjectOfType<AudioManager>().Play("button");
      Rotator.speed = 100f;
      Score.score = 0;
      SceneManager.LoadScene("Main");
    }
}
