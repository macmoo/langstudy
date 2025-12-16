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
        Vector3 vec = new Vector3(0, 0.1f, 0);

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 
                                 Input.GetAxis("Vertical"),
                                 0);

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
                                  Input.GetAxisRaw("Vertical"),
                                  0);

        transform.Translate(vec);
    }

    Vector3 target = new Vector3(3, 2, 0);
    void Update()
    {
        // 1. MoveTowards : 등속이동
        // 현재위치, 목표위치, 속도
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);

        // 2. SmoothDamp : 부드러운 감속 이동
        // 현재위치, 목표위치, 참조속도, 속도(반비례하여 속도 증가)
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);
        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        // 3. Lerp : 선형보간, SmoothDamp보다 감속시간이 김
        transform.position = Vector3.Lerp(transform.position, target, 0.05f);

        // 4. Slerp : 구면 선혀보간, 호를 그리며 이동
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);

    }
}
