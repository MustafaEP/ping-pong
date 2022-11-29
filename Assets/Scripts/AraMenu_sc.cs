using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AraMenu_sc : MonoBehaviour
{
    public GameObject _menuObject;


    public bool _menuOpen;
    void Start()
    {
        _menuOpen = true;
    }

    // Update is called once per frame
    void Update()
    {

        float inputCancel = Input.GetAxis("Cancel");
        
        if (inputCancel == 1)
        {
            _menuOpen = !_menuOpen;
        } 
        
            if(_menuOpen == true)
            {
                _menuObject.SetActive(true);
                Time.timeScale = 0.02f;
            }
            else
            {
                _menuObject.SetActive(false);
                Time.timeScale = 1f;
            }
        
        
        
    }

    public void onClickDevamEt()
    {
        _menuOpen = false;
    }

    public void onClickYenidenBaslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
