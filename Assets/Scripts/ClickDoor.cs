using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickDoor : MonoBehaviour
{
    public Texture2D cursor1;
    public Texture2D cursor2;

    public static bool exit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor1, Vector2.zero, CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        exit = true;
    }
}
