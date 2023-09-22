using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class InventoryUI : MonoBehaviour
{
    public ItemSlotUI[] uiSlots;
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _itemsCountText;
    [SerializeField] private TMP_Text _itemsMaxCountText;
    [SerializeField] private List<ItemData> _items = new List<ItemData>();
    [SerializeField] private List<int> _equippedItemsIndex= new List<int>();
    private int _selectedItemIndex;
    private int uiSlotsLength;

    private void Awake()
    {
        uiSlotsLength = uiSlots.Length;
        _itemsMaxCountText.text = "180";
    }

    public void UpdateUI()
    {
        _items = _player.GetInventory();
        _equippedItemsIndex = _player.GetEquippedItemsIndex();
        _itemsCountText.text = _items.Count.ToString();
        for (int i = 0; i < uiSlotsLength; i++)
        {
            if (i < _items.Count)
            {
                if (_equippedItemsIndex.Contains(i))
                    uiSlots[i].equipIcon.gameObject.SetActive(true);
                else
                    uiSlots[i].equipIcon.gameObject.SetActive(false);

                uiSlots[i].Set(_items[i], i);
            }
            else
                uiSlots[i].Clear();
        }
    }

    public void SelectItem(int index)
    {
        _selectedItemIndex = index;
        if (_equippedItemsIndex.Contains(_selectedItemIndex))
            UIManager.instance.OpenEquipPopup(_items[_selectedItemIndex], true);
        else
            UIManager.instance.OpenEquipPopup(_items[_selectedItemIndex], false);
    }

    public void ConfirmItem()
    {
        if (_equippedItemsIndex.Contains(_selectedItemIndex))
        {
            _player.UnEquipItem(_selectedItemIndex);
        }
        else
        {
            _player.EquipItem(_selectedItemIndex);
        }

        UpdateUI();
    }
}
