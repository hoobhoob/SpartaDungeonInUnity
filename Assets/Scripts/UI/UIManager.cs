using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("Player Data")]
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _playerJob;
    [SerializeField] private TMP_Text _playerName;
    [SerializeField] private TMP_Text _playerLevel;
    [SerializeField] private TMP_Text _playerExp;
    [SerializeField] private TMP_Text _playerMaxExp;
    [SerializeField] private TMP_Text _playerInfo;
    [SerializeField] private TMP_Text _playerGold;
    [SerializeField] private Image _uiExpBar;

    [Header("Player Stats")]
    [SerializeField] private TMP_Text _atk;
    [SerializeField] private TMP_Text _def;
    [SerializeField] private TMP_Text _hp;
    [SerializeField] private TMP_Text _critical;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        _playerJob.text = _player.GetJob();
        _playerName.text = _player.GetName();
        _playerLevel.text = _player.GetLevel().ToString();
        _playerExp.text = _player.GetExp().ToString();
        _playerMaxExp.text = _player.GetMaxExp().ToString();
        _uiExpBar.fillAmount = _player.GetExpPercentage();
        _playerInfo.text = _player.GetInfo();
        _playerGold.text = _player.GetGold().ToString();
    }

    public void UpdateLevelUI()
    {
        _playerLevel.text = _player.GetLevel().ToString();
        _playerExp.text = _player.GetExp().ToString();
        _playerMaxExp.text = _player.GetMaxExp().ToString();
        _uiExpBar.fillAmount = _player.GetExpPercentage();
    }

    public void UpdateGoldUI()
    {
        _playerGold.text = _player.GetGold().ToString();
    }

    public void UpdateStatsUI()
    {
        _atk.text = _player.stats.Atk.ToString();
        _def.text = _player.stats.Def.ToString();
        _hp.text = _player.stats.Hp.ToString();
        _critical.text = _player.stats.Critical.ToString();
    }
}
