using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int maxHealth = 10000;
    [SerializeField] private FloatingHPDisplay  floatingHPDisplay;
    private DamageEnemy manager;

    void OnEnable()
    {
        if (manager == null)
        {
            manager = GameObject.FindGameObjectWithTag("DamageManager").GetComponent<DamageEnemy>();
        }
        
        manager.OnAttack += TakeDamage;
    }

    void OnDisable()
    {
        manager.OnAttack -= TakeDamage;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        //floatingHPDisplay.UpdateHealthBar(health, maxHealth);
    }

    // Update is called once per frame
    /*void Update()
    {
        var value = Random.Range(0, 1);

        switch (value)
        {
            case 0:
                TakeDamage(1);
                break;
            case 1:
                break;
        }
    }*/

    public void TakeDamage(int damage)
    {
         health = Mathf.Clamp(health - damage ,0, maxHealth);
         //floatingHPDisplay.UpdateHealthBar(health, maxHealth);
    }

    public int GetHealth()
    {
        return health;
    }
}
