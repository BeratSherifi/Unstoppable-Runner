using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    private GameObject[] AudioObject;

    private void Awake()
    {
        AudioObject = GameObject.FindGameObjectsWithTag("BGMusic");
        if(AudioObject.Length >=2)
        {
            Destroy(AudioObject[1]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
