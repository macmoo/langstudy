using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 초기화 -> (활성화) -> 물리 -> 게임로직 -> 해체
    void Awake()
    {
        // 게임오브젝트 생성할때 최초 실행
        // 플레이어 데이터 준비     
        Debug.Log("Awake");
    }
    void OnEnable()
    {
        // 게임 오브젝트가 활성화 되었을 때
        // 활성화될때마다 실행됨
        // 로그인
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // 업데이트 시작 직전, 최초 실행
        Debug.Log("Start");
    }
    void FixedUpdate()
    {
        // 물리연산업데이트
        // 고정된 실행주기로 cpu를 많이 사용
        // 1초에 약 50회 실행
        Debug.Log("FixedUpdate");
    }
    void Update()
    {
        // 게임 로직 없데이트 
        // 환경에 따라 실행주기가 떨어질 수 있음
        Debug.Log("Update");
    }
    void LateUpdate()
    {
        // 모든 업데이트 끝난 후
        // 카메라등 후처리
        Debug.Log("LateUpdate");
    }
    void OnDisable()
    {
        // 게임 오브젝트가 비활성화 되었을 때
        // 로그아웃
        Debug.Log("OnDisable");


    }
    void OnDestroy()
    {
        // 게임오브젝트가 삭제 될때
        // 플레이어 데이터 해제
        Debug.Log("OnDestroy");

    }

}
