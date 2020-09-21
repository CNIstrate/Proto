using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStartButtonColor : MonoBehaviour
{
    private void OnMouseEnter()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.green;
    }

    private void OnMouseExit()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
