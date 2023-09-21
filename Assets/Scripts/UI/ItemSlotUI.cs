using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlotUI : MonoBehaviour
{
    public Button button;
    public Image icon;
    private ItemData curItem;
    private Outline outline;

    public int index;
    public bool equipped;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnEnable()
    {
        outline.enabled = equipped;
    }

    public void Set(ItemData item)
    {
        curItem = item;
        icon.gameObject.SetActive(true);
        icon.sprite = item.icon;

        if (outline != null)
        {
            outline.enabled = equipped;
        }
    }

    public void Clear()
    {
        curItem = null;
        icon.gameObject.SetActive(false);
    }

    public void OnButtonClick()
    {
        Debug.Log($"{curItem.name} clicked");
    }
}
