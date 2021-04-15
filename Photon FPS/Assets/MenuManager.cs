using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    [SerializeField]
    Menu[] menus;

    void Awake()

    {
        Instance = this;
    }
    
    public void OpenMenu(string _menuName)
    {
        for(int i=0; i<menus.Length; i++)
        {
            if(menus[i].menuName == _menuName)
            {
                OpenMenu(menus[i]);
            }
            else if(menus[i].open)
            {
                CloseMenu(menus[i]);
            }
        }
    }


    public void OpenMenu(Menu _menu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
           
            if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }
        }

        _menu.Open();
    }

    public void CloseMenu(Menu _menu)
    {
        _menu.Close();
    }

}
