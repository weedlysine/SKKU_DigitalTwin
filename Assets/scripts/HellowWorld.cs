using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellowWorld : MonoBehaviour
{
    int? a;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
        int age;
        age = 1;

        Run();

        Debug.Log("hello world");

    }
    void Run()
    {
        Debug.Log("run");
    }

    
}
