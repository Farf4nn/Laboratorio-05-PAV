using UnityEngine;

public class GameManager : Personaje
{
    public Personaje personaje;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (personaje == null)
        {
            Debug.LogError("Personaje no asignado.");
            return;
        }

        personaje.Talk("¡Bienvenido, viajero!");
        personaje.Talk("Has llegado justo a tiempo.");
        personaje.Talk("¡Nos atacan!", Emotion.Scared);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
