using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Weapon
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Shoot()
    {
        Debug.Log(weaponName + ":振り下ろす,シャキーーン");
        Debug.Log("残り使用可能回数は" + expend() );
    }
    Sword(string weaponName, uint maxTimes, uint expendTimes)
    {
        Init(weaponName, maxTimes, expendTimes);
    }
}
