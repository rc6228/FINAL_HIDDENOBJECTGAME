using UnityEngine;
using UnityEngine.InputSystem;

public class CursorControls : MonoBehaviour

{
    private Vector2 positionTracker;
    private float followSpeed = 1.0f;
    private float trackingSpeed = 0.5f;
   

    
    void Start()
    {
        Cursor.visible = false;
    }

    
    void Update()
    {
      positionTracker = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //FOR PRECISE FOLLOW 
        transform.position = positionTracker; 
        transform.position = Vector2.Lerp(transform.position, positionTracker, Time.deltaTime * followSpeed);
     
    }
}