using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Esperar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Esperar()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
    }

}
