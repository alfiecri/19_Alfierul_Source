using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("InstructionScene");
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
