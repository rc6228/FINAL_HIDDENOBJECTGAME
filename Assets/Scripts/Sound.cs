using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource Success;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Success = GetComponent<AudioSource>(); 

    }

    void OnMouseDown()
    {

        if (gameObject.CompareTag("Correct"))
        {
            Success.Play();

        }
    }

}
