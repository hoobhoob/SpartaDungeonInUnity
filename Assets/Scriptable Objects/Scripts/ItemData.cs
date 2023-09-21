using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor,
    Helmet,
    Boots,
    Ring,
    Potion
}

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public ItemType type;
    public string description;
    public Sprite icon;

    [Header("Stats")]
    public Stats stats;
}
