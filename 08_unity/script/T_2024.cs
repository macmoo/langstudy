using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ---------------------------------
abstract public class Car{
    public virtual void run(){
        Debug.Log("RUN!!");
    }
    public void stop(){
        Debug.Log("STOP!");
    }
}
public class SportCar : Car{
    public override void run(){
        Debug.Log("Sports Car RUNNNN!");
        base.run();
    }
}

// ---------------------------------
public class Test : MonoBehaviour
{
    // ---------------------------------
    private float startAt;
    private IEnumerator testLoop;
    // ---------------------------------
    enum GameMode { Easy, Normal, Hard };
    GameMode gm = GameMode.Easy;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("----- START");
        // ---------------------------------
        Debug.Log("---------------------------------");
        var test="TEST!";
        Debug.Log(test);
        Debug.Log(test.Length);
        test = null;
        // Debug.Log(test.Length); // null pointer error
        // ---------------------------------
        // Array
        Debug.Log("---------------------------------");
        int[] v1 = new int[]{1,2,3};
        Debug.Log(v1.Length);
        Debug.Log(v1[0]);
        v1[0] = 100;
        Debug.Log(v1[0]);
        // ---------------------------------
        // List
        Debug.Log("---------------------------------");
        List<int> v2 = new List<int>{4,5,6};
        Debug.Log(v2.Count);
        Debug.Log(v2[0]);
        v2[0]=111;
        Debug.Log(v2[0]);
        v2.Add(999);
        Debug.Log(v2[v2.Count-1]);
        // ---------------------------------
        // Dictionary
        Debug.Log("---------------------------------");
        Dictionary<string, int> v3 = new Dictionary<string, int>{
            {"하나",1},
            {"둘",2},
            {"셋",3},
        };
        Debug.Log(v3.Count);
        v3["하나"]=100;
        Debug.Log(v3["하나"]);
        v3.Add("넷",4);
        Debug.Log(v3["넷"]);
        Debug.Log("---------------------------------");
        // ---------------------------------
        // Enum
        Debug.Log("---------------------------------");
        Debug.Log(gm);
        // ---------------------------------
        // vector
        Debug.Log("---------------------------------");
        var position = new Vector3(0,1,2);
        transform.position = position;
        Debug.Log(position.normalized);
        Debug.Log(position.magnitude);

        Debug.Log(new Vector3(3,1,0)+new Vector3(5,3,1));
        Debug.Log(new Vector3(3,1,0)*2/5);

        Debug.Log(Vector3.zero);
        Debug.Log(Vector3.up);
        Debug.Log(Vector3.forward);
        Debug.Log("---------------------------------");
        // ---------------------------------
        // foreach
        var v4 = new int[]{1,10,10,1000};
        foreach(var v in v4){
            Debug.Log(v);
        }
        Debug.Log("---------------------------------");
        // ---------------------------------
        // while
        var v5 = 0;
        while (v5 < 10){
            v5 = Random.Range(0,100);
            Debug.Log(v5);
        }
        Debug.Log("---------------------------------");
        // ---------------------------------
        // virtual
        var spCar = new SportCar();
        spCar.run();
        spCar.stop();
        Debug.Log("---------------------------------");
        // ---------------------------------
        // co rutine
        Debug.Log("---------------------------------");
        startAt = Time.realtimeSinceStartup;
        testLoop = TestLoop();
        StartCoroutine(testLoop);

        // ---------------------------------
        // 
        Debug.Log("---------------------------------");

    }
    private IEnumerator TestLoop(){
        while(true){
            var lifeTime = Time.realtimeSinceStartup - startAt;
            Debug.Log("오브젝트 생존 시간(초):" + lifeTime);

            if(lifeTime >= 30){
                Debug.Log("TestLoop를 정지함");
                yield break;
            }
            yield return new WaitForSeconds(1f);
        }
    }

    void Awake()
    {
        // Debug.Log("----- AWAKE");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("----- UPDATE");
    }
}

