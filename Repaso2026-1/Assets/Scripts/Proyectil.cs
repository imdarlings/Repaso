using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float velMov = 1f;
    float mov;

    void Update()
    {
        mov = velMov * Time.deltaTime;
        transform.Translate(0, 0, mov);
    }
}
