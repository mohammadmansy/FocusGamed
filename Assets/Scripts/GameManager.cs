using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
public class GameManager : MonoBehaviour
{
    [SerializeField] private float timer = 30;
    // Start is called before the first frame update
    void Start()
    {

    }

    //private void Awake()
    //{
    //    pop.onClicked += PopClicked;
    //}

    //private void OnDestroy()
    //{
    //    pop.onClicked -= PopClicked;
    //}

    //private void PopClicked()
    //{
    //    if (pop.Unclicked.Count == 0)
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //    }
    //}

    private void Update()
    {
        if (timer <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}