using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : Fruits
{
    private void Start()
    {
        ScoreCount = 8;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore(collision);
    }
}
