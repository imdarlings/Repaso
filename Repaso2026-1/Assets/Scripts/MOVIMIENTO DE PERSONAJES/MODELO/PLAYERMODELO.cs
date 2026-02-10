using UnityEngine;

public class PLAYERMODELO : MonoBehaviour
{
    [SerializeField]
    private PLAYERCONTROLLER playerController;
 
    public Rigidbody rb;
    
    float velocidad = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }
    private void Movimiento()
    {
        if (isMove) 
        {
            rb.linearVelocity = playerController.DireccionJugador() * velocidad;
        }
    }

}
