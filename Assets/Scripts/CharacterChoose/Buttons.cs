using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private readonly static int classBtnNum = 4;
    public Button[] classBtns = new Button[classBtnNum];
 
    private void Start()
    {
        for (int i = 0; i < classBtns.Length; ++i)
        {
            int j = i;
            classBtns[i].onClick.AddListener(() => ClassBtnOnClickEvent(j));
        }

    }

    private void ClassBtnOnClickEvent(int _buttonNum)
    {
        Debug.Log(classBtns[_buttonNum].name + "Å¬¸¯");
        GameManager.Instance.classNum = (GameManager.myClassNum)_buttonNum + 1;
        GameManager.Instance.isChoose = true;
    }
}
