using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBMoveScript : MonoBehaviour
{
    public GameObject player;

    float xSpeed = 5;
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
            if (transform.position.x >= -62)
            {
                transform.Translate(Vector3.right * Time.deltaTime * -xSpeed);
            }
            else
            {
                platformStay = !platformStay;
            }
        }

        if (!platformStay)
        {
            if (transform.position.x <= -35)
            {
                transform.Translate(Vector3.right * Time.deltaTime * xSpeed);
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