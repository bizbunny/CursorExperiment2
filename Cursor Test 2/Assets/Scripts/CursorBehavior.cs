using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehavior : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite handCursor;
    public Sprite normalCursor;

    void Start(){
        Cursor.visible = false;
        rend = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//stores the cursor position
        transform.position = cursorPos; //set sprite position to cursorPos

        if(Input.GetMouseButtonDown(0)){
            rend.sprite = handCursor;
        }
        else if(Input.GetMouseButtonUp(0)){
            rend.sprite = normalCursor;
        }       
    }
}
