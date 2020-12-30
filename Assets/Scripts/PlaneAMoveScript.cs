using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAMoveScript : MonoBehaviour
{
    public GameObject player;

    float zSpeed = 10;
    bool platformStay = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (platformStay)
        {
            if (transform.position.z >= -16.5)
            {
                transform.Translate(Vector3.back * Time.deltaTime * zSpeed);
            }
            else
            {
                platformStay = !platformStay;
            }
        }

        if (!platformStay)
        {
            if (transform.position.z <= 17.5)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * zSpeed);
            }
            else
            {
                platformStay = !platformStay;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                player.transform.parent = null;
            }
        }
    }
}
