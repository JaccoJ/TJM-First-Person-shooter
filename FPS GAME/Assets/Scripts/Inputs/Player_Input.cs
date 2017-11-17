using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour
{
    private MassiveShot _playershoot;
    private float _Firerate = 10.0f;
    private float _NextFire = 0.0f;

    void Awake()
    {
        _playershoot = GetComponent<MassiveShot>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Time.time > _NextFire)
        {
            _NextFire = Time.time + _Firerate;
            _playershoot.Shoot();
        }

    }

}