using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumTest : MonoBehaviour {

    public string[] ansValue;
    int count;
    public enum ans
    {
        A, B, C, D
    };

    public ans myAns;
    private void isAns()
    {
        if (count == ansValue.Length)
        {
            count = 0;
            print("過關");
        }
        else if (ansValue[count] == myAns.ToString())
        {
            print("正確答案是" + myAns);
            count++;            
        }
        else
            print("錯誤");       
    }

    public void A()
    {
        myAns = ans.A;
        isAns();
    }
    public void B()
    {
        myAns = ans.B;
        isAns();
    }
    public void C()
    {
        myAns = ans.C;
        isAns();
    }
    public void D()
    {
        myAns = ans.D;
        isAns();
    }
}


