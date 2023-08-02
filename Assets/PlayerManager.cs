using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private CharacterHealth _health;

    // Start is called before the first frame update
    void Start()
    {
        _health = GetComponent<CharacterHealth>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("sjdsjdf");
        _health.Damage(20);
    }

}