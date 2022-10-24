using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    //hello info
    string heroName = "Muneera";
    int heroPower = 97;

    //villian info 
    string villianName = "Moon";
    int villianPower = 99;


    float playerSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(heroPower > villianPower)
        {
            print("hero is stronger");
        }
        else if (villianPower > heroPower)
        {
            print("villian is stronger");
        }
        else
        {
            print("they are equal");
        }

        SetSpeed(2.5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetSpeed(float speed)
    {
        print(playerSpeed);
        playerSpeed = speed;
        print(playerSpeed);
    }
}
