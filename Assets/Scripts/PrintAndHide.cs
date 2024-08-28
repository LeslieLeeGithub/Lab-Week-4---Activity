using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    private int counter = 3;

    public Renderer rend;

    private int randomBluethreshold;





    // Start is called before the first frame update
    void Start()
    {
        randomBluethreshold = Random.Range(150,251);
    }

    // Update is called once per frame
    void Update()
    {

        counter++;

        Debug.Log($"{gameObject.name}:{counter}");


        if (gameObject.CompareTag("Red") && counter == 100)
        {
            gameObject.SetActive(false);


        }


        if (gameObject.CompareTag("Blue") && counter == randomBluethreshold)
        {
            Renderer renderer = GetComponent<Renderer>();

            if (renderer != null)
            {
                renderer.enabled = false;


            }




        }

    }
}
