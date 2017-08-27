using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health = 50;
    public int RespawnDelay = 2;
    int _currentHealth;
    int currentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;

            if(_currentHealth <= 0)
            {
                Die();
            }
        }
    }
    //public void TakeDamage(float amount)
    //{
    //    health -= amount;
    //    if(health <= 0f)
    //    {
    //        Die();
    //    }
    //}
    void Die()
    {
        var respawner = new GameObject("Respawner for" + gameObject.name).AddComponent<Respawner>();

        respawner.target = gameObject;
        respawner.delay = RespawnDelay;
        currentHealth = health;
    }

    void Start()
    {
        currentHealth = health;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
    }
}
