using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour
{
    [SerializeField] private EntityDataSO data;
    [SerializeField] private Image HPBar;
    [SerializeField] private TMP_Text HPText;
    [SerializeField] private float HPBarLifeTime = 5f;
    private float curHP;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        curHP = data.maxHP;
        HPBar.enabled = false;
        HPText.enabled = false;
    }
    private void Update()
    {
        if(timer > HPBarLifeTime && HPBar.enabled)
        {
            timer = 0;
            HPBar.enabled = false;
            HPText.enabled = false;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void TakeDamage(float dmg)
    {
        if (!HPBar.enabled)
        {
            HPBar.enabled = true;
            HPText.enabled = true;
            HPText.text = data.enemyName;
        }
        else
        {
            HPText.text = data.enemyName;
            timer = 0;
        }
        
        curHP -= dmg;
        HPBar.fillAmount = curHP / data.maxHP;
        if(curHP < 0)
        {
            for(int i =0; i < data.resCount; i++)
            {
                Instantiate(data.resPref, transform.position+new Vector3(Random.Range(-0.8f,0.9f), Random.Range(-0.9f, 1.1f), transform.position.z), transform.rotation);
            }
            HPBar.enabled = false;
            HPText.enabled = false;
            Destroy(gameObject);
        }
    }
}
