using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;
    private ItemData _item;

    public int index;

    public void Set(ItemData item)
    {
        _item = item;
        icon.gameObject.SetActive(true);
        icon.sprite = item.icon;
    }

    public void Clear()
    {
        _item = null;
        icon.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        Debug.Log($"{_item.name} clicked");
    }
}
