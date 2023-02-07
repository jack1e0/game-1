using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndGame : MonoBehaviour
{
    public Animator animator;
    public Texture2D cursor;
    

    // Update is called once per frame
    void Update()
    {
        if (Click1Door.hasExitedGame)
        {
            animator.SetTrigger("HasEnded");
            Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        }
    }

    public void endGame()
    {
        animator.SetTrigger("hasFaded");
        

    }
}
