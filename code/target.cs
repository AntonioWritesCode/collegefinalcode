using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class target : MonoBehaviour
{
    public float health = 1;
    public float armor = 1;
    public int enemyDamage = 1;
    public float armorDamage = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }

        armor -= amount;
        if(armor <= 0f)
        {
            gameObject.SetActive(false);
        }


        void Die()
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.gameObject.GetComponent<playerHealth>().myHealth =- 1;
            collision.gameObject.GetComponent<playerHealth>().myArmor =- 5;
        }
    }
}
