using UnityEngine;

public class funciones : MonoBehaviour

{

    private int numeroEntero = 2;

    public Clases ListaEstudiantes = new Clases();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyFuncion();
    }

    public void MyFuncion()
    {
        Debug.Log(ListaEstudiantes.estudiantes[3]);
    }
    
}
