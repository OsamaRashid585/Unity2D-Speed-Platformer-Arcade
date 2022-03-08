using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    public int ScoreCount;
    private UIManager _uiManager;
    private void Awake()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }
    public void AddScore(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _uiManager.Score += ScoreCount;
            Destroy(gameObject);
        }
    }
}
