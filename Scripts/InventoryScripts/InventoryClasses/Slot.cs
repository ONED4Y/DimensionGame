using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot {
    public Item ItemInSlot = null;
    public bool AddItem(Item ItemToAdd) {
        if(ItemInSlot == null) {
            ItemInSlot = ItemToAdd;
            return true;
        } else {
            return false;
        }
    }
    public void RemoveItem() {
        ItemInSlot = null;
    }
}