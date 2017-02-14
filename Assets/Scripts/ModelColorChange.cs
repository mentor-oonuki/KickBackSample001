using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ModelColorChange : MonoBehaviour
{

    // モデルのマテリアルの色を変更する
    public void ColorChange(Color color)
    {
        Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();

        foreach(Renderer renderer in renderers)
        {
            renderer.material.color = color;
        }

    }

    private void Start()
    {
        ColorChange(new Color(0.5f, 0.0f, 0.0f));
    }

}