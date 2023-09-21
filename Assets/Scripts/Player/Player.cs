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
        job = "�ڵ��뿹";
        playerInfo = "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�. ���õ� ����ϸ� ���Ƽ� ġŲ�� ��ų���� �𸥴ٴ� ������ ����� Ű�� �ֳ׿�.";
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
