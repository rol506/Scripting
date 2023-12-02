using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float seconds;
    public int minutes;
    public int roundSeconds;

    private void Update()
    {
        if (seconds <= 0)
        {
            if (seconds <= 0)
            {
                seconds += 60;
                minutes--;
            } else if (seconds <= 0 && minutes <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        seconds -= Time.deltaTime;
        roundSeconds = Mathf.RoundToInt(seconds);
    }

}
