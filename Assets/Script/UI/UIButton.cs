using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] texts;

    public void AttackPowerUP(int amount)
    {
        GameManger.instance.playerData.AttackPower += amount;
        texts[0].text = "Attack Level : " + GameManger.instance.playerData.AttackPower;
    }
    public void DefensePowerUP(int amount)
    {
        GameManger.instance.playerData.Speed += amount;
        texts[1].text = "Speed : " + GameManger.instance.playerData.Speed;
    }
    public void MoneyUP(int amount)
    {
        GameManger.instance.playerData.Money += amount;
        texts[2].text = "Money : " + GameManger.instance.playerData.Money + "$";
    }
}
