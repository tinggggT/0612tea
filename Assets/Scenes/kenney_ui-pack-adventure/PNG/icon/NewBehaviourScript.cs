using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void 首頁(){
        SceneManager.LoadScene("00");
        }
    public void 如何採茶()
    {
        SceneManager.LoadScene("00_如何採茶");
    }
    public void 第二頁()
    {
        SceneManager.LoadScene("02");
    }
    public void 第三頁()
    {
        SceneManager.LoadScene("03");
    }
    public void 第四頁()
    {
        SceneManager.LoadScene("04");
    }
    public void 第五頁()
    {
        SceneManager.LoadScene("05");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
