using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame_Manager : MonoBehaviour
{
    public GameObject startscreen, block1, block2, block3, block4, block5, block6, block7, block8, block9, 
        block10, block11, block12, block13, block14, block15, block16, block17, block18, block19, block20, block21, 
        block22, block23, block24, block25, block26, block27, block28, block29, block30, block31, block32, block33, 
        block34, block35, block36, block37, block38, ENDING1, ENDING2, ENDING3, ENDING4, sub_block1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startbutton()
    {
        startscreen.SetActive(false);
        block1.SetActive(true);
    }

    public void block1choices1() 
    {
        block1.SetActive(false);
        block2.SetActive(true);
    }

    //block2
    public void block2choices1()
    {
        block2.SetActive(false);
        block16.SetActive(true);
    }

    public void block2choices2()
    {
        block2.SetActive(false);
        block3.SetActive(true);
    }

    //block3
    public void block3choices1()
    {
        block3.SetActive(false);
        block10.SetActive(true);
    }

    public void block3choices2()
    {
        block3.SetActive(false);
        block4.SetActive(true);
    }

    //block4
    public void block4choices1()
    {
        block4.SetActive(false);
        block5.SetActive(true);
    }

    //block5
    public void block5choices1()
    {
        block5.SetActive(false);
        block6.SetActive(true);
    }

    //block6
    public void block6choices1()
    {
        block6.SetActive(false);
        block7.SetActive(true);
    }
    //killed a person ENDING
    public void block6choices2()
    {
        block6.SetActive(false);
        ENDING1.SetActive(true);
    }

    //block7
    public void block7choices1()
    {
        block7.SetActive(false);
        block8.SetActive(true);
    }

    //block8
    public void block8choices1()
    {
        block8.SetActive(false);
        block9.SetActive(true);
    }

    //block9
    public void block9choices1()
    {
        block9.SetActive(false);
        ENDING2.SetActive(true);
    }

    //block10
    public void block10choices1()
    {
        block10.SetActive(false);
        block11.SetActive(true);
    }

    //block11
    public void block11choices1()
    {
        block11.SetActive(false);
        block13.SetActive(true);
    }

    public void block11choices2()
    {
        block11.SetActive(false);
        block12.SetActive(true);
    }

    //block12
    public void block12choices1()
    {
        block12.SetActive(false);
        ENDING3.SetActive(true);
    }

    //block13
    public void block13choices1()
    {
        block13.SetActive(false);
        sub_block1.SetActive(true);
    }

    public void sub_block1choices1()
    {
        sub_block1.SetActive(false);
        ENDING1.SetActive(true);
    }

    public void block13choices2()
    {
        block13.SetActive(false);
        block14.SetActive(true);
    }

    public void block13choices3()
    {
        block13.SetActive(false);
        block5.SetActive(true);
    }

    //block14
    public void block14choices1()
    {
        block14.SetActive(false);
        block15.SetActive(true);
    }

    //block15
    public void block15choices1()
    {
        block15.SetActive(false);
        ENDING3.SetActive(true);
    }

    //block16
    public void block16choices1()
    {
        block16.SetActive(false);
        block17.SetActive(true);
    }

    //block17
    public void block17choices1()
    {
        block17.SetActive(false);
        block28.SetActive(true);
    }

    public void block17choices2()
    {
        block17.SetActive(false);
        block18.SetActive(true);
    }

    //block18
    public void block18choices1()
    {
        block18.SetActive(false);
        block19.SetActive(true);
    }

    //block19
    public void block19choices1()
    {
        block19.SetActive(false);
        block20.SetActive(true);
    }

    //block20
    public void block20choices1()
    {
        block20.SetActive(false);
        block21.SetActive(true);
    }

    //block21
    public void block21choices1()
    {
        block21.SetActive(false);
        block22.SetActive(true);
    }

    //block22
    public void block22choices1()
    {
        block22.SetActive(false);
        block23.SetActive(true);
    }

    //block23
    public void block23choices1()
    {
        block23.SetActive(false);
        block24.SetActive(true);
    }

    //block24
    public void block24choices1()
    {
        block24.SetActive(false);
        block25.SetActive(true);
    }

    //block25
    public void block25choices1()
    {
        block25.SetActive(false);
        block26.SetActive(true);
    }

    //block26
    public void block26choices1()
    {
        block26.SetActive(false);
        block27.SetActive(true);
    }

    //block27
    public void block27choices1()
    {
        block27.SetActive(false);
        ENDING4.SetActive(true);
    }

    //block28
    public void block28choices1()
    {
        block28.SetActive(false);
        block29.SetActive(true);
    }

    //block29
    public void block29choices1()
    {
        block29.SetActive(false);
        block31.SetActive(true);
    }

    public void block29choices2()
    {
        block29.SetActive(false);
        block30.SetActive(true);
    }

    //block30
    public void block30choices1()
    {
        block30.SetActive(false);
        block21.SetActive(true);
    }

    //block31
    public void block31choices1()
    {
        block31.SetActive(false);
        block32.SetActive(true);
    }

    //block32
    public void block32choices1()
    {
        block32.SetActive(false);
        block33.SetActive(true);
    }

    //block33
    public void block33choices1()
    {
        block33.SetActive(false);
        block35.SetActive(true);
    } 

    public void block33choices2()
    {
        block33.SetActive(false);
        block34.SetActive(true);
    }

    //block34
    public void block34choices1()
    {
        block34.SetActive(false);
        block7.SetActive(true);
    }

    //block35
    public void block35choices1()
    {
        block35.SetActive(false);
        block36.SetActive(true);
    }

    //block36
    public void block36choices1()
    {
        block36.SetActive(false);
        block37.SetActive(true);
    }

    //block37
    public void block37choices1()
    {
        block37.SetActive(false);
        sub_block1.SetActive(true);
    }

    public void block37choices2()
    {
        block37.SetActive(false);
        block38.SetActive(true);
    }

    //block38
    public void block38choices1()
    {
        block38.SetActive(false);
        ENDING4.SetActive(true);
    }
}
