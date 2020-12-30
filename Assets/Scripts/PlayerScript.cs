using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject wall;

    float speed = 4;
    float jump = 5;
    public bool isOnGround = true;
    public bool isHitBox = false;

    public Rigidbody playerRb;
    public Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player walking
        if (Input.GetKey(KeyCode.W))
        {
            playerAnim.SetBool("playerWalk", true);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnim.SetBool("playerWalk", true);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerAnim.SetBool("playerWalk", true);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerAnim.SetBool("playerWalk", true);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        // Stop animations
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            playerAnim.SetBool("playerWalk", false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.SetBool("playerJump", false);
        }


        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            playerRb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetBool("playerJump", true);
        }

        // Death

        if (transform.position.y <= -10)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.tag == "Button")
        {
            Object.Destroy(wall);
        }
    }
}
