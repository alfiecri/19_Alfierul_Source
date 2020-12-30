using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAWallScript : MonoBehaviour
{

    float xSpeed = 10;
    bool wallMove = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!wallMove)
        {
            if (transform.position.x >= -25)
            {
                transform.Translate(Vector3.right * Time.deltaTime * -xSpeed);
            }
            else
            {
                wallMove = !wallMove;
            }
        }

        if (wallMove)
        {
            if (transform.position.x <= 25)
            {
                transform.Translate(Vector3.right * Time.deltaTime * xSpeed);
            }
            else
            {
                wallMove = !wallMove;
            }
        }

    }
}
