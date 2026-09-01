using UnityEngine;
using UnityEngine.InputSystem;

public class DamageTester : MonoBehaviour
{
    public GameObject[] enemies;
    public int damageAmount = 10;
     //Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnDamage(InputAction.CallbackContext context)
    {
        if (!context.performed)
        {
            return;
        }
        foreach (GameObject enemy in enemies)
        {
            if (enemy == null) continue;
            IDamageable damageable = enemy.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(damageAmount);
            }
        }
    }
 

     //Update is called once per frame
   // void Update()
   // {
        
   // }
}
