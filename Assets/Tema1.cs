using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    public float monto;
    public string conversion;
    // Start is called before the first frame update
    void Start()
    {
        float monto_dolares = monto /191.34f;
        float monto_euros = monto / 122.22f;
        float monto_reales = monto / 23.97f; 


        if (monto < 1000)
        {
            Debug.Log("El monto minimo es $1000");
        }
        else
        {
            switch(conversion)
            {
                case "D":
                    Debug.Log(monto + " pesos argentinos equivalen a "+ monto_dolares+" dolares");
                    break;
                case "E":
                    Debug.Log(monto + " pesos argentinos equivalen a " + monto_euros + " euros");
                    break;
                case "R":
                    Debug.Log(monto + " pesos argentinos equivalen a " + monto_reales + " reales");
                    break;
                default:
                    Debug.Log("Opción de moneda extranjera no valida");
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
