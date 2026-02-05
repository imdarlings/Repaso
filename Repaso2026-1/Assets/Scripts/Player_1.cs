using UnityEngine;

public class Player_1 : MonoBehaviour
{
    public float velMov = 1f;
    public float velRot = 100f;
    float mov;
    float rot;

    private void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            Translacion();
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            Rotacion();
        }
    }

    void Translacion()
    {
        mov = Input.GetAxis("Vertical") * velMov * Time.deltaTime;
        transform.Translate(0, 0, mov);
    }

    void Rotacion()
    {
        rot = Input.GetAxis("Horizontal") * velRot * Time.deltaTime;
        transform.Rotate(0, rot, 0);
    }


}
