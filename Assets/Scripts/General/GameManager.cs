using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GenericSingleton<GameManager>
{
    public bool isChoose = false;

    public enum myClassNum
    {
        //default
        class0,
        class1,
        class2,
        class3,
        class4,
    }

    public myClassNum classNum = myClassNum.class0;

    

    private void Start()
    {
        StartCoroutine(WaitForClassChosseCo());

    }

    private IEnumerator WaitForClassChosseCo()
    {
        yield return new WaitUntil(() => isChoose == true);
        isChoose = false;
        SceneManager.LoadScene("Main");
        StartCoroutine(WaitForClassChosseCo());
    }
}