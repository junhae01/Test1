using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_002 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        int answer2;
        answer2 = n1 + n2;
        Debug.Log(answer2);

        int answer3 = 10;
        answer3 += 5;               //정수 answer3에 +5값을 추가 (answer3 = answer3 + 5)
        Debug.Log(answer3);
        answer3++;                  //정수 answer3에 +1 값을 추가
        Debug.Log(answer3);

        string str = "happy ";      //뮨자열 str에 "happy " 입력
        string str2 = "birthday";   //문자열 str에 "birthday" 입력

        str += str2;                //str = str + str2 
        Debug.Log(str);

        string message = str + answer3;     // 문자열 message를 선언하고 (string)값 str과 (int)값 answer3를 더한다.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
