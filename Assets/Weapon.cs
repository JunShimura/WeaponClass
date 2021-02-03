using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected string weaponName;        // 名前を保持するメンバ変数
    protected uint maxTimes;                  //使用できる回数
    protected uint lastTimes;              //残りの使用回数
    protected uint expendTimes;          //一度の使用で消費する使用回数
    protected uint expend()
    {
        lastTimes -= expendTimes;
        return lastTimes;
    }
    public abstract void Shoot();   // 武器を使用するメンバ関数
    string getName()
    {
        return name;
    }
    protected  void  Init(string name, uint maxTimes, uint expendTimes)    // コンストラクタ
    {
        this.weaponName = name;
        this.maxTimes = maxTimes;
        this.expendTimes = expendTimes;
        lastTimes = maxTimes;
    }

}
