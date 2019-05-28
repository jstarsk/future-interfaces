using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletprefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int bulletSpeed = 40;
            print("Shooting---->>>>>>");
            GameObject copyOfPrefab = Instantiate(bulletprefab);
            copyOfPrefab.transform.position = this.transform.position;

            Rigidbody prefabRb = copyOfPrefab.GetComponent<Rigidbody>();
            prefabRb.velocity = Vector3.forward * bulletSpeed;

        }
        
    }
}
