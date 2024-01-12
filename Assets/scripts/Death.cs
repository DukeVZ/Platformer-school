using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject Player;
    
    // when you die you go back the start

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            Player.transform.position = startPoint.transform.position;
        } 
    }
}
