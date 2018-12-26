using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPos : MonoBehaviour {


    public GameObject[] SET;
    public GameObject[] create;

    private void Update()
    {
        create = GameObject.FindGameObjectsWithTag("create");

        if (Input.GetMouseButtonDown(0))
        {
            setting();
        }

        FullSetting();
    }

    void setting()
    {
        foreach(var set in SET)
        {
            if(set.activeSelf)
            {
                Instantiate(gameObject, set.transform.position, set.transform.rotation);
                set.SetActive(false);
                break;
            }
        }
    }

    void FullSetting()
    {
        if(!SET[SET.Length - 1].activeSelf)
        {            
            for(int i = 0; i < SET.Length; i++)
            {                
                SET[i].SetActive(true);
                Destroy(create[i]);
            } 
        }
    }
}
