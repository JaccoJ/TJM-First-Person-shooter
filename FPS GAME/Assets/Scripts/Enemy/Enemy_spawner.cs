    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

public class Enemy_spawner : MonoBehaviour {

    [SerializeField]
    private ParticleSystem effect;

    public Transform target;
    public float _Speed;
    public Rigidbody _Rigidbody;
    public float spawnTime;
    public bool gameOver;
    public Transform[] spawnPoints;
    public GameObject Enemy;
        
    void Start()
    {
        gameOver = false;
        target = GameObject.Find("Player").transform;
        _Rigidbody = GetComponent<Rigidbody>();
        spawnTime = spawnTime;
    }

    void Update()
    {
        if (!gameOver)
        {
            if (spawnTime <= 0)
            {
                Invoke("Spawn", spawnTime);
                spawnTime = 3;
            }
            else
            {
                spawnTime -= Time.deltaTime;
            }

        }
    }
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Vector3 Pos = new Vector3(spawnPoints[spawnPointIndex].position.x + Random.Range(-5f, 5f), spawnPoints[spawnPointIndex].position.y + 0.5f, spawnPoints[spawnPointIndex].position.z + Random.Range(-5f, 5f));
        Instantiate(Enemy, Pos, spawnPoints[spawnPointIndex].rotation);
        effect.transform.position = Pos;
        effect.Play();
    }
}