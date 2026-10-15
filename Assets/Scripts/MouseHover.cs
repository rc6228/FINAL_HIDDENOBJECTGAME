using UnityEngine;
using TMPro;

public class MouseHover : MonoBehaviour

{
    Color s_MouseOverColor = Color.blue;
    Color s_OriginalColor;
    SpriteRenderer s_Renderer;
    public TMP_Text scoreText;
    private int score;
    public AudioSource Sound;
 

void Start()
{
    //Fetch the sprite renderer component from the GameObject
    s_Renderer = GetComponent<SpriteRenderer>();
    //Fetch the original color of the GameObject
    s_OriginalColor = s_Renderer.material.color;
    
}


    void OnMouseOver() //this makes the object fet tinted a different color when it is hovered over!
    {
        //GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);
        Debug.Log("Mouse is over GameObject.");
        s_Renderer.material.color = s_MouseOverColor;
    }

    void OnMouseExit() //this changes the tint back to normal!
    {
        //GetComponent<Image>().color += new Color(0f, 0f, 0f, 1f);
        Debug.Log("Mouse is no longer on GameObject.");
        s_Renderer.material.color = s_OriginalColor;
    }
    
    void OnMouseDown() //this makes the object tagged "correct" get destroyed on click!
    {
   
        if (gameObject.CompareTag("Correct"))
        {
            Sound.Play();
            score++;
            scoreText.text = score.ToString();
            Destroy(gameObject);

         }

    }
}
