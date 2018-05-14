using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{

    [SerializeField]
    private string m_EntityName = "Entity";
    public string EntityName
    {
        get
        {
            return m_EntityName;
        }
    }
    
    [SerializeField]
    private Color32 m_EntityColor;
    public Color32 EntityColor
    {
        get
        {
            return m_EntityColor;
        }
    }


    private Renderer m_Rend;

    private void Awake()
    {
        m_Rend = GetComponent<Renderer>();
    }

    private void Start()
    {
        m_Rend.material.color = m_EntityColor;
    }

    protected virtual void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Entity>())
        {
            Debug.Log("Hey!, I'm " + EntityName + " and I just collided with " + other.GetComponent<Entity>().EntityName);
            //other.GetComponent<Renderer>().material.color = EntityColor;
            SwitchColor(other.GetComponent<Entity>().CurrentColor);
        }
    }

    Color32 m_CurrentColor;
    public Color32 CurrentColor
    {
        get
        {
            return m_CurrentColor;
        }
    }

    private void SwitchColor(Color32 newColor)
    {
        m_Rend.material.color = newColor;
        m_CurrentColor = m_Rend.material.color;
    }

}
