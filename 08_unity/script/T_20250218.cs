using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        // 아무 입력을 최초로 받을때 true
        if (Input.anyKeyDown)
            Debug.Log("Input.anyKeyDown");
        // 아무 입력을 받으면 true
        if (Input.anyKey)
            Debug.Log("Input.anyKey - 누르고 있을 때");
        
        // GetKey 키보드 입력을 받으면 true
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("enter down");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("Move Left");
        if (Input.GetKey(KeyCode.RightArrow))
            Debug.Log("Move Right");

        // GetMouse 마우스 입력
        if (Input.GetMouseButtonDown(0))
            Debug.Log("GetMouseButtonDown 0");
        if (Input.GetMouseButton(0))
            Debug.Log("GetMouseButton 0 - 누르고 있을 때");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("GetMouseButtonUp 0");

        // InputManager
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는중!");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("점프 key up!");

        if (Input.GetButtonDown("SuperCancel"))
            Debug.Log("SuperCancel");

        if (Input.GetButton("Horizontal"))
            Debug.Log("횡 이동중.."+ Input.GetAxis("Horizontal"));
        if (Input.GetButton("Vertical"))
            Debug.Log("종 이동중.." + Input.GetAxisRaw("Vertical"));

    }
}
