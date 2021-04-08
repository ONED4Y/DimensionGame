using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {
    public Slot[] Slots = new Slot[9];
    public Inventory() {
        for(int i = 0; i < 9; i++) {
            Slots[i] = new Slot();
        }
    }
    public void ClearInventory() {
        Slots = new Slot[9];
        for(int i = 0; i < 9; i++) {
            Slots[i] = new Slot();
        }
    }
}
