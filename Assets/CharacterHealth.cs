using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public TMP_Text healthText;

    private int _health = 100;
    private int _maxhealth = 100;

    public void DisplayHealth()
    {
        healthText.text = "Health:" + _health;
    }

    public void Damage(int damage)
    {
        _health -= damage;

        if(_health <= 0)
        { 
            _health = 0;
            Destroy(gameObject);
        }
        DisplayHealth();
    }
    public void Heal (int heal)
    {
        _health += heal;

        if(_health > 100)
        {
            _health = 100;
            DisplayHealth();
        }
    }
}
