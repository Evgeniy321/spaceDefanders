using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private MissaleDataSO missale;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate;
    [SerializeField] private KeyCode fireButton;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(Input.GetKey(fireButton) && timer > (1 / fireRate))
        {
            Instantiate(missale.pref, firePoint.position, firePoint.rotation).Setup(firePoint);
            timer = 0;
        }
    }
}
