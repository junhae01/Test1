using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < 10; i += 2)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 3; i > 0; i--)
        //{
        //    Debug.Log(i);
        //}

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("==================================");

        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += 1;
        }
        Debug.Log(sum);

        Debug.Log("================������===============");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Debug.Log(i.ToString() + " X " + j.ToString() + " = " + (i * j).ToString());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
