using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeLapseCounter : MonoBehaviour
{
    public TextMeshProUGUI txtLapse;
    float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            elapsedTime = 0;
        }

        elapsedTime = elapsedTime + Time.deltaTime;
        txtLapse.text = Mathf.Floor(elapsedTime).ToString();
    }
}
