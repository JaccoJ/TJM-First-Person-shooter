using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassiveShot : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public GameObject kogelspawn;
    public GameObject kogelPrefab;
    [SerializeField]
    private float kogelspeed;

    public void Shoot()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
        //KOGELS SPAWNEN
        GameObject Temporary_kogel_handeler;
        Temporary_kogel_handeler = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        GameObject Temporary_kogel_handeler_1;
        Temporary_kogel_handeler_1 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        GameObject Temporary_kogel_handeler_2;
        Temporary_kogel_handeler_2 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;
        
        GameObject Temporary_kogel_handeler_3;
        Temporary_kogel_handeler_3 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        //KOGELS SPAWNEN (DIAGONAAL)
        GameObject Temporary_kogel_handeler_4;
        Temporary_kogel_handeler_4 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        GameObject Temporary_kogel_handeler_5;
        Temporary_kogel_handeler_5 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        GameObject Temporary_kogel_handeler_6;
        Temporary_kogel_handeler_6 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        GameObject Temporary_kogel_handeler_7;
        Temporary_kogel_handeler_7 = Instantiate(kogelPrefab, kogelspawn.transform.position, kogelspawn.transform.rotation) as GameObject;

        //KOGELS RIGIDBODY
        Rigidbody Temporary_RigidBody;
        Temporary_RigidBody = Temporary_kogel_handeler.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_1;
        Temporary_RigidBody_1 = Temporary_kogel_handeler_1.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_2;
        Temporary_RigidBody_2 = Temporary_kogel_handeler_2.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_3;
        Temporary_RigidBody_3 = Temporary_kogel_handeler_3.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_4;
        Temporary_RigidBody_4 = Temporary_kogel_handeler_4.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_5;
        Temporary_RigidBody_5 = Temporary_kogel_handeler_5.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_6;
        Temporary_RigidBody_6 = Temporary_kogel_handeler_6.GetComponent<Rigidbody>();

        Rigidbody Temporary_RigidBody_7;
        Temporary_RigidBody_7 = Temporary_kogel_handeler_7.GetComponent<Rigidbody>();

        //KOGELS BEWEGING
        Temporary_RigidBody.AddForce(new Vector3(-1, 0, 0) * kogelspeed);
        Temporary_RigidBody_1.AddForce(new Vector3(1, 0, 0) * kogelspeed);
        Temporary_RigidBody_2.AddForce(new Vector3(0, 0, -1) * kogelspeed);
        Temporary_RigidBody_3.AddForce(new Vector3(0, 0, 1) * kogelspeed);
        //KOGELS BEWEGING (DIAGONAAL)
        Temporary_RigidBody_4.AddForce(new Vector3(-1, 0, 1) * kogelspeed);
        Temporary_RigidBody_5.AddForce(new Vector3(1, 0, -1) * kogelspeed);
        Temporary_RigidBody_6.AddForce(new Vector3(-1, 0, -1) * kogelspeed);
        Temporary_RigidBody_7.AddForce(new Vector3(1, 0, 1) * kogelspeed);

        //KOGELS DESTROY
        Destroy(Temporary_kogel_handeler, 1.0f);
        Destroy(Temporary_kogel_handeler_1, 1.0f);
        Destroy(Temporary_kogel_handeler_2, 1.0f);
        Destroy(Temporary_kogel_handeler_3, 1.0f);
        Destroy(Temporary_kogel_handeler_4, 1.0f);
        Destroy(Temporary_kogel_handeler_5, 1.0f);
        Destroy(Temporary_kogel_handeler_6, 1.0f);
        Destroy(Temporary_kogel_handeler_7, 1.0f);

    }
}