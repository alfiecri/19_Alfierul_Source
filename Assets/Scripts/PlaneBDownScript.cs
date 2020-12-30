using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneBDownScript : MonoBehaviour
{
    public GameObject player;

    float ySpeed = 5;
    bool elevatorMove = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (elevatorMove)
        {
            if (transform.position.y <= 25)
            {
                transform.Translate(Vector3.up * Time.deltaTime * ySpeed);
            }
            else
            {
                elevatorMove = !elevatorMove;
            }
        }
        if (!elevatorMove)
        {
            if (transform.position.y >= 15)
            {
                transform.Translate(Vector3.down * Time.deltaTime * ySpeed);
            }
            else
            {
                elevatorMove = !elevatorMove;
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