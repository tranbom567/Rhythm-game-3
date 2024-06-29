using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSplitApply : MonoBehaviour
{
    public Material mat;
    public static float ammount = 1;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if(mat == null)
        {
            Graphics.Blit(source, destination);
            return;
        }
        mat.SetFloat("_Ammount", ammount);
       Graphics.Blit(source,destination,mat);
    }
    
}
