using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitpoints = 100f;
    bool isDead = false;
    public bool IsDead()
    {
        return isDead;
    }
    public void Takedamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        hitpoints-=damage;
        if (hitpoints<=0)
        {
            Die();
        }
    }
    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");

    }
}
