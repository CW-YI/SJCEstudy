using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string Name;
    public int AttackPower;
    public int Speed;
    public int Money;
}


public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    public PlayerData playerData= new PlayerData();

    public bool isAttacking = false;
    private void Awake()
    {
        #region singleton
        if (instance == null) instance = this;
        else if (instance != this) Destroy(instance.gameObject);

        DontDestroyOnLoad(gameObject);
        #endregion

        // initial values
        playerData.AttackPower = 1;
        playerData.Speed = 1;
        playerData.Money = 0;
    }
}
