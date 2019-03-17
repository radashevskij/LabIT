using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    [SerializeField]
    private float maxHealth = 100f;

    [SyncVar]
    public float currHealth;

    void Awake()
    {
        currHealth = maxHealth;
    }
   
    
    
    public void TakeDamage(float damage)
    {
        currHealth -= damage;
        if (currHealth > 0)
            Debug.Log(transform.name + " имеет уровень здоровья равный: " + currHealth);
        else
            Debug.Log(transform.name + " убит!"); 
    }

    
    
}
