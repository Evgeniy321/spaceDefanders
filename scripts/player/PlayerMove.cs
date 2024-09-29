using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private EntityDataSO data;
    public EntityDataSO Data => data;
    private Rigidbody2D rb;
    private Vector2 inputDir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputDir.x = Input.GetAxis("Horizontal");
        inputDir.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * data.speed * Time.deltaTime * inputDir.y;
        rb.rotation -= inputDir.x * Time.fixedDeltaTime * data.rotateSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        StartCoroutine(stopRotation());
            
        
    }

    IEnumerator stopRotation()
    {
        yield return new WaitForSeconds(0.2f);
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        
        rb.constraints = RigidbodyConstraints2D.None;

    }
}
