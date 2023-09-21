using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public string job;
    public string playerInfo;
    [SerializeField] private int _level;
    [SerializeField] private int _exp;
    [SerializeField] private int _maxExp;
    [SerializeField] private int _gold;
    public Stats stats = new Stats();

    private void Awake()
    {
        InitializePlayer();
    }

    public void InitializePlayer()
    {
        playerName = "Chad";
        job = "코딩노예";
        playerInfo = "코딩의 노예가 된지 10년짜리 되는 머슴입니다. 오늘도 밤샐일만 남아서 치킨을 시킬지도 모른다는 생각에 배민을 키고 있네요.";
        _level = 1;
        _exp = 0;
        _maxExp = _level + 2;
        _gold = 200000;
        stats.Atk = 35;
        stats.Def = 40;
        stats.Hp = 100;
        stats.Critical = 25;
    }

    public void GetExp(int amount)
    {
        _exp += amount;
        if (_exp >= _maxExp)
        {
            _exp -= _maxExp;
            levelUp();
        }
    }

    public void levelUp()
    {
        _level += 1;
        _maxExp = _level + 2;
        stats.Atk += 5;
        stats.Def += 5;
        stats.Hp += 10;
        stats.Critical += 5;
    }
}
