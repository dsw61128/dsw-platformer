using UnityEngine;

public class deathbox : MonoBehaviour
{

    public float damage = 1019;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(collision.gameObject);

        collision.GetComponent<Health_Component>().AddDamage(damage);
    }
}
