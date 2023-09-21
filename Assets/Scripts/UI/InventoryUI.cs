using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class InventoryUI : MonoBehaviour
{
    public ItemSlotUI[] uiSlots;
    [SerializeField] private Player _player;

    private ItemData _selectedItem;
    private List<ItemData> _items = new List<ItemData>();
    private List<int> _equipItemsIndex = new List<int>();
    private int curEquipIndex;


    void UpdateUI()
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if (_items[i] != null)
                uiSlots[i].Set(_items[i]);
            else
                uiSlots[i].Clear();
        }
    }

    public void SelectItem(int index)
    {
        
    }

}
