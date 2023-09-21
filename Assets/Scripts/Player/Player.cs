using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string _playerName;
    [SerializeField] private string _job;
    [SerializeField] private string _playerInfo;
    [SerializeField] private int _level;
    [SerializeField] private int _exp;
    [SerializeField] private int _maxExp;
    [SerializeField] private int _gold;
    [SerializeField] private List<ItemData> _inventory;
    [SerializeField] private List<int> _equipItemIndex;
    public Stats stats = new Stats();

    private void Awake()
    {
        Initialize();
    }

    public void Initialize()
    {
        _playerName = "Chad";
        _job = "�ڵ��뿹";
        _playerInfo = "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�. ���õ� ����ϸ� ���Ƽ� ġŲ�� ��ų���� �𸥴ٴ� ������ ����� Ű�� �ֳ׿�.";
        _level = 1;
        _exp = 0;
        _maxExp = _level + 2;
        _gold = 200000;
        _inventory = new List<ItemData>();
        stats.Atk = 35;
        stats.Def = 40;
        stats.Hp = 100;
        stats.Critical = 25;
    }

    public void ObtainExp(int amount)
    {
        _exp += amount;
        while (_exp >= _maxExp)
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

    #region Get
    public string GetName()
    {
        return _playerName;
    }

    public string GetJob()
    {
        return _job;
    }

    public string GetInfo()
    {
        return _playerInfo;
    }

    public int GetLevel()
    {
        return _level;
    }

    public int GetExp()
    {
        return _exp;
    }

    public int GetMaxExp()
    {
        return _maxExp;
    }

    public int GetGold()
    {
        return _gold;
    }

    public List<ItemData> GetInventory()
    {
        return _inventory;
    }

    public float GetExpPercentage()
    {
        return _exp / _maxExp;
    }
    #endregion
}
