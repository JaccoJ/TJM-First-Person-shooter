using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public Slider slider;
    public int scoreValue = 1;
    private float timeToCollect = 1.0f;
    private float collect = 0f;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && Time.time > collect)
        {
            collect = Time.time + timeToCollect;
            Destroy(gameObject);
            audioSource.clip = audioClip;
            audioSource.Play();
            Score.score += scoreValue;
            slider.value = Score.score;
        }
    }

    void Update()
    {
        print(Score.score);
        if (Score.score == 5)
        {
            Application.LoadLevel(4);
        }
        
    }
}