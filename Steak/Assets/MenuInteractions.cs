using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInteractions : MonoBehaviour
{

    public GameObject start, options, quit, startCube, optionsCube, quitCube;
    public Animator anim;
    public int levelToLoad;

    private void Start()
    {
    }

    void Update()
    {
        DetectMenuOption();

    }

    private void DetectMenuOption()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            var color = hit.transform.GetComponent<MeshRenderer>();

            if (hit.transform.gameObject.tag == "MenuStart")
            {
                Debug.Log("This is the start button!");
                if (Input.GetMouseButtonDown(0)){
                    startCube.GetComponent<Rigidbody>().AddForce(15f * Vector3.forward, ForceMode.Impulse);
                    FadeToLevel(1);
                }

            }
            else if (hit.transform.gameObject.tag == "MenuOptions")
            {
                Debug.Log("This is the options button!");
                if (Input.GetMouseButtonDown(0)) {
                    optionsCube.GetComponent<Rigidbody>().AddForce(15f * Vector3.forward, ForceMode.Impulse);
                }

            }
            else if (hit.transform.gameObject.tag == "MenuQuit")
            {
                Debug.Log("This is the quit button!");
                if (Input.GetMouseButtonDown(0)){
                    quitCube.GetComponent<Rigidbody>().AddForce(15f * Vector3.forward, ForceMode.Impulse);
                    Application.Quit();
                    Debug.Log("Game is exiting");

                }

            }
            else
            {
                return;
            }
        }
        
    }

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = levelIndex;
        anim.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
