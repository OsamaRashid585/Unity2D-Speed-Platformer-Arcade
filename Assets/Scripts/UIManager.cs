using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text _scoreTxT;
    public int Score;

    private void Awake()
    {
        _scoreTxT = GameObject.Find("Score").GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        _scoreTxT.text = "Score: " + Score;
    }
}
