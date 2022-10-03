using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTubo : MonoBehaviour
{
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= -6.4f)
        {
            transform.position = new Vector2(6.4f,transform.position.y);
        }

        transform.Translate(velocidad * Time.deltaTime, 0, 0);  
    }
}
