using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackFadeIn : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (ClickDoor.exit)
        {
            startFade();
        }
    }

    private void startFade()
    {
        animator.SetTrigger("FadeIn");
    }

    public void changeScene()
    {
        SceneManager.LoadScene(1);
        Click1Door.hasExitedGame = false;
        Click1Door.exitGame = false;
    }
}
