using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Basklass för alla ARObjekt som kommer dyka upp på Image Targets
/// </summary>
public class Entity : MonoBehaviour
{
    [SerializeField]
    //Namn på objektet
    private string m_EntityName = "Entity";
    public string EntityName
    {
        get
        {
            return m_EntityName;
        }
    }

    [SerializeField]
    //Objektets originalfärg
    private Color32 m_OriginalColor;
    public Color32 OriginalColor
    {
        get
        {
            return m_OriginalColor;
        }
    }

    //Renderingkomponenten på vårt objekt
    private Renderer m_Rend;

    //Använd Awake för att upprätta referenser
    private void Awake()
    {
        m_Rend = GetComponent<Renderer>();
    }

    //Använd Start för att ge ett värde att börja med
    private void Start()
    {
        m_Rend.material.color = m_OriginalColor;
    }

    //När en trigger (Collider) passerar in i det här objektets collider
    protected virtual void OnTriggerEnter(Collider other)
    {
        //Kolla om det finns någon Entity på det objektet
        if (other.GetComponent<Entity>())
        {
            //Om det finns. Hämta det objektets färg och sätt in det vi vår SwitchColor metod
            SwitchColor(other.GetComponent<Entity>().OriginalColor);
        }
    }

    //Flagga för om objektet har sin originalfärg
    bool HasOriginalColor = true;
    //Metod för att byta sin nuvarande färg till en annan färg.
    private void SwitchColor(Color32 newColor)
    {
        //Kolla flaggan om den har originalfärgen
        if (HasOriginalColor)
        {
            //Om den har det
            //Sätt den nya färgen till vårt material
            m_Rend.material.color = newColor;
        }
        else
        {
            //Annars, återställ till originalfärgen
            m_Rend.material.color = OriginalColor;
        }

        //Invertera flaggan så att den togglar som tänkt.
        HasOriginalColor = !HasOriginalColor;
    }
        
}