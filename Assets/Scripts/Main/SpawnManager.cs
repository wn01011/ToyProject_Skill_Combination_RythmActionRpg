using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    private GameObject playerGo = null;
    public void Init()
    {
        playerGo = Resources.Load("Prefabs/Player") as GameObject;

        Spawn(GameManager.Instance.classNum, playerGo);
    }

   

    private void Spawn(GameManager.myClassNum _classNum, GameObject _gameObject)
    {
        switch (_classNum)
        {
            case GameManager.myClassNum.class1:
                break;
            case GameManager.myClassNum.class2:
                break;
            case GameManager.myClassNum.class3:
                break;
            case GameManager.myClassNum.class4:
                break;
            default:
                break;
        }

        GameObject player = Instantiate(_gameObject, transform.position, Quaternion.identity, transform);

    }
}
