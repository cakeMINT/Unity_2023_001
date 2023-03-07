using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Data : MonoBehaviour
{
    public Entity_Sheet1 Entity_GameDB;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Entity_Sheet1.Param param in Entity_GameDB.sheets[0].list)
        {
            Debug.Log(param.index + " - " + param.character + " - " + param.Hp + " - "+ param.Mp);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
