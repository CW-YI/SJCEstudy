using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] texts;
    private int[] Levels;

    private void Start()
    {
        Levels = new int[texts.Length];
        for (int i = 0; i < texts.Length; i++) Levels[i] = 0;
    }
    public void AttackPowerUP(int amount)
    {
        Levels[0] += amount;
        texts[0].text = "Attack Level : " + Levels[0];
    }
    public void DefensePowerUP(int amount)
    {
        Levels[1] += amount;
        texts[1].text = "Defense Level : " + Levels[1];
    }
    public void MoneyUP(int amount)
    {
        Levels[2] += amount;
        texts[2].text = "Money : " + Levels[2] + "$";
    }
}
