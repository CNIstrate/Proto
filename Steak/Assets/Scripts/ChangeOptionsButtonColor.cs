using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOptionsButtonColor : MonoBehaviour
{
    private void OnMouseEnter()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
