using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // TRANSFORM
    void Start()
    {
        Vector3 vec = new Vector3(5, 0, 0);
        // 벡터값을 현재 위치에 더하는 함수
        transform.Translate(vec);
    }

    void Update()
    {
        //Vector3 vec = new Vector3(0, 0.1f, 0);

        //Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 
        //                          Input.GetAxis("Vertical"),
        //                          0);

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
                                  Input.GetAxisRaw("Vertical"),
                                  0);
        // 벡터값을 현재 위치에 더하는 함수
        transform.Translate(vec);
    }
}
