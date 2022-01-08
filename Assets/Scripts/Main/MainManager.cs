using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    private SpawnManager spawnManager = null;
    private int classNum = 0;

    private void Start()
    {
        #region Initialization

        spawnManager = FindObjectOfType<SpawnManager>();
        classNum = (int)GameManager.Instance.classNum;

        spawnManager.Init();
        
        #endregion
    }
}
