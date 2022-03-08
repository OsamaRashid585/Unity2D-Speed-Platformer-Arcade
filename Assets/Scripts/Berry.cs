using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berry : Fruits
{
    private void Start()
    {
        ScoreCount = 2;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        AddScore(collision);
    }
}
