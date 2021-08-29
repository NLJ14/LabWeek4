using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private const string x = ":";
    int i, randValue;
   
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randValue = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        
        i++;
        Debug.Log(gameObject.name + x + i);

        if (gameObject.CompareTag("Red") && i == 100)
            gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue") && i == randValue)
            rend.enabled = false;
    }
}
