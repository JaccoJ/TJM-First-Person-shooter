using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Player_Shoot : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    [SerializeField]
    private ParticleSystem effect;

    [SerializeField]
    private ParticleSystem effect2;
    public bool isFire;
    public bool bigFire;
    //mana
    public float maxMana = 100f;
    public float currentMana;
    public Slider manaBar;

    //massiveshot
    private MassiveShot _playershoot;
    private float _Firerate = 10.0f;
    private float _NextFire = 0.0f;

    //raycast
    public RaycastHit hit;

    void Start()
    {
        currentMana = 100;
    }

    void Awake()
    {
        _playershoot = GetComponent<MassiveShot>();
    }

    void Update()
    {
        manaBar.value = currentMana;
        currentMana += 0.1f;

        if (currentMana >= 100)
        {
            currentMana = 100;
        }
        if (currentMana <= 5)
        {
            isFire = false;
        }
        if (currentMana >= 6)
        {
            isFire = true;
        }
        if (currentMana <= 25)
        {
            bigFire = false;
        }
        if (currentMana >= 26)
        {
            bigFire = true;
        }

        if (isFire && Input.GetMouseButtonDown(0))
        {
            effect2.Play();
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            currentMana -= 5;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                print(hit.point);
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    audioSource.clip = audioClip;
                    audioSource.Play();
                    effect.transform.position = hit.point;
                    effect.Play();
                    Destroy(hit.collider.gameObject);
                    StartCoroutine(DoPHP(transform.position.x, transform.position.y));
                }
            }
        }
        //massiveshot 
        if (Input.GetMouseButtonDown(1) && bigFire)
        {
            currentMana -= 25;
           
            _playershoot.Shoot();
        }
    }
    IEnumerator DoPHP(float transX, float transY)
    {
        WWW request = new WWW("http://22053.hosts.ma-cloud.nl/php.php?pos=[" + transX + "," + transY + "]&player_id=1");
        yield return request;
        Debug.Log("Request returned");
    }
}