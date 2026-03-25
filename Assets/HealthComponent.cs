using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    private float health = 10;
    public float maxhealth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);
    }

    void FixedUpdate()
    {
        if (health <= 0)
        {
                Destroy(gameObject);
        }


    }
    public void AddHealth(float heal)

    {

        health += heal;
      

        if(health >= maxhealth)
        {
            health = maxhealth;

        }
        Debug.Log(health);
    }
}