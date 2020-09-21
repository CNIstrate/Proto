using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggColorSwitch : MonoBehaviour
{

    Renderer eggRenderer;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        eggRenderer = this.GetComponent<Renderer>();
        StartCoroutine(SwitchColor());
    }


    public IEnumerator SwitchColor()
    {
        eggRenderer.material.color = Color.red;
        yield return new WaitForSeconds(.5f);
        eggRenderer.material.color = Color.white;
        yield return new WaitForSeconds(.5f);
        eggRenderer.material.color = Color.red;
        yield return new WaitForSeconds(.3f);
        eggRenderer.material.color = Color.white;
        yield return new WaitForSeconds(.3f);
        eggRenderer.material.color = Color.red;
        yield return new WaitForSeconds(.1f);
        eggRenderer.material.color = Color.white;
        yield return new WaitForSeconds(.1f);
        eggRenderer.material.color = Color.red;
        yield return new WaitForSeconds(.1f);
        eggRenderer.material.color = Color.white;
        yield return new WaitForSeconds(.1f);
        eggRenderer.material.color = Color.red;
        text.SetActive(true);        
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
        text.SetActive(false);

        
        

    }

}
