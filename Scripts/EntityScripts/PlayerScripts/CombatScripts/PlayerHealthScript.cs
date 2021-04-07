using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript: MonoBehaviour {
    public int PlayerHealth = 6;
    public int MaxHealth = 6;
    void Start() {
    }


    void Update() {
    }


    public void GetDamage(int aDamage) {
        PlayerHealth -= aDamage;
        checkedHealth();
        Debug.Log(PlayerHealth);
    }


    void checkedHealth() {
        if(PlayerHealth <= 0) {
            PlayerHealth = 0;
            PlayerDie();
        }
        else if (PlayerHealth >= MaxHealth) {
            PlayerHealth = MaxHealth;
        }

    }


    void addMaxHealth(int AddNum) {
        MaxHealth += AddNum;
    }


    void PlayerDie() {
        //scene switch to death screen
    }

    void AddHealth(int AddNum) {
        //minus Magisches wasser
        //or beim Schlafen im Bett die hälfte vom MaxHealth/wenn im Krankenhaus dann full
        //macht weniger Schaden und langsamer wenn er lange nicht schläft 
        PlayerHealth += AddNum;
    }

    
}

