using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int score;
    // Use this for initialization
    Text text;

    void Start()
    {

    }

    // Update is called once per frame


    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        text.text = score + " / 5 collected";

    }



}