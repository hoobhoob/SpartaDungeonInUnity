using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Image icon;
    public Image equipIcon;

    [SerializeField] private ItemData _item;
    [SerializeField] private int _index;
    private InventoryUI _inventoryUI;


    private void Awake()
    {
        _inventoryUI = GetComponentInParent<InventoryUI>();
    }

    public void Set(ItemData item, int index)
    {
        icon.gameObject.SetActive(true);
        _item = item;
        icon.sprite = item.icon;
        _index = index;
    }

    public void Clear()
    {
        _item = null;
        _index = -1;
        icon.gameObject.SetActive(false);
        equipIcon.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        if(_index != -1)
            _inventoryUI.SelectItem(_index);
    }
}
