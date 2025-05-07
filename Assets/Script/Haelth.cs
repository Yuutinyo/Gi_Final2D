using UnityEngine;

public class Haelth : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float currentHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            
        }
        else
        {
            
        }
    }
}
