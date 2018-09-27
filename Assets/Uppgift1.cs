using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgift1 : MonoBehaviour
{
    public int UseValue;
    public int points = 10;
    public int Dragon;
    public int player = 100;
    
	void Start ()
    {
        Random.Range(100, 150 + Dragon);
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log(UseValue + 2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log(UseValue / 2);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(UseValue);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Random.Range(0, 10 + points);
            Random.Range(0, 10 - points);
            if (points >= 20)
            {
                Debug.Log("Win");
            }
            if (points <= 0)
            {
                Debug.Log("Lose");
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Random.Range(5, 25 - Dragon);
            Random.Range(10, 20 - player);
        }

    }
}
