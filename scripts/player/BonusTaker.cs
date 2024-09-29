using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BonusTaker : MonoBehaviour
{
    [SerializeField] private string bonusTag;


    private int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("here");
        if (collision.CompareTag("bonus"))
        {
            score++;
            Destroy(collision.gameObject);
        }

    }
}
