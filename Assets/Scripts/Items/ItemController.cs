using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTypeEnum {None, Blanket, Food, Money };

public class ItemController : MonoBehaviour
{
    public ItemTypeEnum ItemType = ItemTypeEnum.None;

    public string ItemName = "";
}
