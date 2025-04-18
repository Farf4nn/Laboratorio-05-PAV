using UnityEngine;

public enum Emotion
{
    Neutral,
    Happy,
    Sad,
    Angry,
    Surprised,
    Scared,
    Confused
}

public class Personaje : MonoBehaviour
{
    public string characterName = "Juan";

    // 1. Solo mensaje
    public void Talk(string message)
    {
        Debug.Log($"{characterName}: {message}");
    }

    // 2. Mensaje con emoción
    public void Talk(string message, Emotion emotion)
    {
        Debug.Log($"{characterName} ({emotion}): {message}");
    }

    // 3. Método base con speaker personalizado (opcional, si alguna vez quieres usar otro nombre)
    public void Talk(string speaker, string message, Emotion emotion)
    {
        Debug.Log($"{speaker} ({emotion}): {message}");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
