using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI coins;
    public Player player;
    public Timer timer;
    public TextMeshProUGUI textTimer;

    private void Update()
    {
        slider.maxValue = player.maxHealth;
        slider.value = player.health;
        coins.text = player.coins.ToString();
        textTimer.text = timer.minutes.ToString() + ":" + timer.roundSeconds.ToString();
    }
}
