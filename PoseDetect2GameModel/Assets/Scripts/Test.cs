using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Transform bot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = new Vector3(1, 1, 0);
        bot.rotation = Quaternion.LookRotation(a, bot.right);
    }
}
