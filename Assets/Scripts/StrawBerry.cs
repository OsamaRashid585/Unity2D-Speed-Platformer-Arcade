using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawBerry : Fruits
{
    private void Start()
    {
        ScoreCount = 5;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore(collision);
    }
}
