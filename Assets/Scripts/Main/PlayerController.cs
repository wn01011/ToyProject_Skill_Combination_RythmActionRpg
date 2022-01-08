using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameManager.myClassNum myClass = GameManager.myClassNum.class0;

    private void OnEnable()
    {
        myClass = GameManager.Instance.classNum;
    }
}
