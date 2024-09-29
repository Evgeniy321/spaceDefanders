using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] private string EnemyTag;
    [SerializeField] private MissaleDataSO missale;
    private float timer;
    private Rigidbody2D rb;
    private Vector3 target;
    void Awake()
    {
        timer = 0;
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > missale.lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(EnemyTag))
        {
            collision.GetComponent<HPController>().TakeDamage(missale.dmg);
            Destroy(gameObject);
        }
    }

    public void Setup(Transform firePos)
    {

            Vector2 dir = firePos.up;
            rb.AddForce(dir * missale.StartForce, ForceMode2D.Impulse);
    }

   
}
