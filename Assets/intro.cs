using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    // // kommentar [Ctrl K + C]
    // public syns i unity                      
    // public int testInt = 5; // heltal
    // public float testfloat = 1.0f; //tal med decimaler
    // public double testdouble = 1.00d; // dubbelt så mycke som float
    // public bool testbool = true; // ja eller nej | true/false 
    // public char testchar = 'a'; // ett tecken
    // public string teststring; // flera tecken
    // == lika med
    // != inte lika med
    // <= mindre än eller lika med
    // >= större än eller lika med
    // > större än
    // < mindre än
    // || eller (ore) [Alt Gr + <]
    // Update is called once per frame

    // Use this for initialization
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float basen;
    public float angel;
    public float number;
    public float bitar;
    public string username;
    public bool IsChecked;
    public int MyIntValue = 10;

    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("It's true");
        }
        else
        {
            Debug.Log("kanske");
        }
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift5a();
        Uppgift6();
    }

    void Uppgift6()
    {
        Debug.Log(string.Format("kill {0} please", username));
    }
    void Uppgift5a()
    {
        Debug.Log(360 / bitar);
    }
    void Uppgift5()
    {
        //Debug.Log(360 / angel);
    }
    void Basen()
    {
       
        Debug.Log(basen);
    }
    void Uppgift4()
    {
       // Debug.Log(basen * 8 / 2);
    }
    void Sentence3()
    {
        Debug.Log(sentence3);
    }
    void Sentence2()
    {
        Debug.Log(sentence2);
    }
    void Sentence1()
    {
        Debug.Log(sentence1);
    }
    void Uppgift3()
    {
        //Debug.Log(string.Format("talet {0} upphöjt med 2 blir {1} och kvadtratroten ur {0} blir {2}",
            //number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }
    void Uppgift2()
    {
        Sentence1();
        Sentence2();
        Sentence3();
    }
    void Uppgift1()
    {
        //Debug.Log("svaret på(963 * 421) - (175463 / 87) = ");
        //Debug.Log((963f * 421f) - (175463f / 87f));
        //Debug.Log( string.Format("svaret på(963 * 421) - (175463 / 87) är {0}" , (963f * 421f) - (175463f / 87f)));
    }

    void testfunktion()
    {
        Debug.Log("ok");
    }
    
    void Update()
    {
        //if (MyIntValue == 10 || IsChecked == true)
        //{
        //    print("Måndag");
        //}
        //else if (MyIntValue == 9)
        //{
        //    print("Tisdag");
        //}
        //else
        //{
        //    print("Okänd dag");
        //}

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            print("Reload");
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            MyIntValue = Random.Range(0, 10);
            print(Random.Range(0f, 10f));
        }
    }
}
