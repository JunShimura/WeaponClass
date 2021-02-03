using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float hoge;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<MonoIn>();        //〇　Monoから派生したclassはAddComponent
        //MonoIn monoInTest = new MonoIn();          //✖ 実行時に警告が出る、Start()は動かない
        //gameObject.AddComponent<NoMono>();    //✖エラーでビルド不可
        NoMono noMonoInTest = new NoMono();        //〇 Monoから派生していないclassはnew
    }


    float pastTime = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Weapon[] weapon = GetComponents<Weapon>();
            foreach (Weapon w in weapon)
            {
                w.Shoot();
            }
        }
    }
}


