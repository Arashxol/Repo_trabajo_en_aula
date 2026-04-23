using UnityEngine;

public class Serpiente : MonoBehaviour
{
    private float velocidad = 5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
{
    transform.Translate(Vector2.up * velocidad * Time.deltaTime);
}
else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
{
    transform.Translate(Vector2.down * velocidad * Time.deltaTime);
}
else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
{
    transform.Translate(Vector2.left * velocidad * Time.deltaTime);
}
else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
{
    transform.Translate(Vector2.right * velocidad * Time.deltaTime);
}
    }
}