using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public float maxlives = 100.0f;
    public float currentlives;
    public Slider healthbar;
    private float timeForDamage = 0.5f;
    private float takeDamage = 0.0f;

    // Use this for initialization
    void Start()
    {
        currentlives = maxlives;

    }

    // Update is called once per frame
    void Update()
    {
        print(currentlives);
        healthbar.value = currentlives;
        if (currentlives <= 0)
        {
            maxlives = 0;
            Application.LoadLevel(5);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy" && Time.time > takeDamage)
        {
            takeDamage = Time.time + timeForDamage;
            currentlives -= 10;
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}