using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [Header("--- Enemy Components ---")]
    [SerializeField] Renderer model;
    [SerializeField] NavMeshAgent agent;

    [Header("--- Enemy Stats ---")]
    [SerializeField] int HP;
    [SerializeField] int playerFaceSpeed;
    [SerializeField] int sightAngle;
    [SerializeField] Transform headPOS;

    [Header("--- Enemy Weapon Stats ---")]
    [SerializeField] int shootRate;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform shootPos;

    int HPOG;
    bool isShooting;
    bool playerInRange;
    Vector3 playerDirection;
    float angleToPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CanSeePlayer()
    {

    }

    void FacePlayer()
    {

    }

    public void TakeDamage(int dmg)
    {

    }

    IEnumerator FlashDamage()
    {
        model.material.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        model.material.color = Color.white;

    }

    IEnumerator Shoot()
    {
        isShooting = true;

        Instantiate(bullet, shootPos.position, transform.rotation);

        yield return new WaitForSeconds(shootRate);

        isShooting = false;
    }
}
