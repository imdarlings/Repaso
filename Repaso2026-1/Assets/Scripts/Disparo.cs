using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, this.transform.position, this.transform.rotation);
        }
    }
}
