using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;


    
   

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        

        

        
    }
   

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("unitychan Z: " + (unitychan.transform.position.z - transform.position.z));

        float v = (unitychan.transform.position.z - transform.position.z);
        if (v > 6 )
        {
            Destroy(gameObject);
        }

    }
}
