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

    [Header("EquipPopup")]
    [SerializeField] private GameObject _equipPopup;
    [SerializeField] private GameObject _itemAtk;
    [SerializeField] private TMP_Text _itemAtkValueText;
    [SerializeField] private GameObject _itemDef;
    [SerializeField] private TMP_Text _itemDefValueText;
    [SerializeField] private GameObject _itemHp;
    [SerializeField] private TMP_Text _itemHpValueText;
    [SerializeField] private GameObject _itemCritical;
    [SerializeField] private TMP_Text _itemCriticalValueText;
    [SerializeField] private TMP_Text _itemNameText;
    [SerializeField] private TMP_Text _itemInfoText;
    [SerializeField] private TMP_Text _equipUnEquipText;
    [SerializeField] private Image _itemImage;

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
        _playerGold.text = _player.GetGold().ToString("0,000");
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
        _atk.text = _player.stats.atk.ToString();
        _def.text = _player.stats.def.ToString();
        _hp.text = _player.stats.hp.ToString();
        _critical.text = _player.stats.critical.ToString();
    }

    public void OpenEquipPopup(ItemData item, bool isEquipped)
    {
        _equipPopup.SetActive(true);

        _itemAtk.SetActive(item.stats.atk != 0);
        _itemAtkValueText.text = item.stats.atk.ToString();
        _itemDef.SetActive(item.stats.def != 0);
        _itemDefValueText.text = item.stats.def.ToString();
        _itemHp.SetActive(item.stats.hp != 0);
        _itemHpValueText.text = item.stats.hp.ToString();
        _itemCritical.SetActive(item.stats.critical != 0);
        _itemCriticalValueText.text = item.stats.critical.ToString();

        _itemNameText.text = item.displayName;
        _itemInfoText.text = item.description;

        _itemImage.sprite = item.icon;

        if (isEquipped)
            _equipUnEquipText.text = "장착 해제 하시겠습니까?";
        else
            _equipUnEquipText.text = "장착 하시겠습니까?";
    }
}
