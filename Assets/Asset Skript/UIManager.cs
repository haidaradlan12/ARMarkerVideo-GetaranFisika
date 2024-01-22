using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform Home, Fenomenologis, Simbol, Model, AboutUs;
    // Start is called before the first frame update
    void Start()
    {
        Home.DOAnchorPos(new Vector2(283.21f, 0), 1.0f);
        Fenomenologis.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Simbol.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Model.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        AboutUs.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
    }
    public void MenuHome()
    {
        Home.DOAnchorPos(new Vector2(283.21f, 0), 1.0f);
        Fenomenologis.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Simbol.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Model.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        AboutUs.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
    }
    public void MenuFenomenologis()
    {
        Home.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Fenomenologis.DOAnchorPos(new Vector2(283.21f, 0), 1.0f);
        Simbol.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Model.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        AboutUs.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
    }
    public void MenuSimbol()
    {
        Home.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Fenomenologis.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Simbol.DOAnchorPos(new Vector2(283.21f, 0), 1.0f);
        Model.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        AboutUs.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
    }
    public void MenuModel()
    {
        Home.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Fenomenologis.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Simbol.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Model.DOAnchorPos(new Vector2(283.21f, 0), 1.0f);
        AboutUs.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
    }
    public void MenuAboutUs()
    {
        Home.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Fenomenologis.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Simbol.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        Model.DOAnchorPos(new Vector2(283.21f, -2119), 1.0f);
        AboutUs.DOAnchorPos(new Vector2(283.21f, 0), 1.0f);
    }
}
