using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;


    
   

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
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
