using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeQuitButtonColor : MonoBehaviour
{
    private void OnMouseEnter()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnMouseExit()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
