using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float myHealth = 100f;
    public float myArmor = 0f;
    public Text health;
    public Text armor;
    public Text gameOverText;
    public Camera playerCamera;
    public float enemyDamage;

    // Start is called before the first frame update
    void Start()
    {
        gameOverText.text = "";
        armor.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        health.text = myHealth.ToString();
        armor.text = myArmor.ToString();

        if (myHealth <= 0)
        {
            gameOverText.text = "LOL YOU DIED";
            playerCamera.gameObject.SetActive(true);
            Destroy(gameObject);
            
        }

        if(myArmor <= 0)
        {
            armor.gameObject.SetActive(false);
            playerCamera.gameObject.SetActive(true);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

        void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "Enemy")
            //collision.gameObject.GetComponent<target>().health = -5;
            myHealth -= enemyDamage;
            myArmor -= enemyDamage;
            Debug.Log("player took damage");

           
      }
    }
}
