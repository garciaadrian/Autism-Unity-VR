using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer tipRenderer;
    public GameObject tip;
    [SerializeField] private Color red, blue, yellow, green;
    

    void Start()
    {
        tipRenderer = tip.GetComponent<Renderer>();
    }

    public void ChangeMaterialRed()
    {
        tipRenderer.material.color = red;
    }

    public void ChangeMaterialBlue()
    {
        tipRenderer.material.color = blue;
    }

    public void ChangeMaterialYellow()
    {
        tipRenderer.material.color = yellow;
    }

    public void ChangeMaterialGreen()
    {
        tipRenderer.material.color = green;
    }
}
