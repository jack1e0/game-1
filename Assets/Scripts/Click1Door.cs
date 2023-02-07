using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click1Door : MonoBehaviour
{
    public Texture2D cursor1;
    public Texture2D cursor2;

    public Animator animator;

    public static bool exitGame = false;
    public static bool hasExitedGame = false;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (exitGame)
        {
            animator.SetTrigger("ExitGame");
            StartCoroutine(fading());
        }
    }

    private IEnumerator fading()
    {
        hasExitedGame = true;
        yield return new WaitForSeconds(1);
    }

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursor2, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
    }

    private void OnMouseDown()
    {
        exitGame = true;
        //animator.SetTrigger("ExitGame");
    }
}
