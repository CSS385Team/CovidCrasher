using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinPanel : MonoBehaviour
{
    public static YouWinPanel instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
}
