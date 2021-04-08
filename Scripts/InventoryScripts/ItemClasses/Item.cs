using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Item {
    public string Name;
    public ItemType Type;
    public int ID;
    public bool SlowDown;
    public Func<bool> IFunc; 
    public Item(string _Name, ItemType _Type, int _ID, Func<bool> _IFunc, bool _SlowDown = false) {
        Name = _Name; Type = _Type; ID = _ID; SlowDown = _SlowDown;
        IFunc = _IFunc;
    }
}

public enum ItemType {
    Regular, Dungeon
}