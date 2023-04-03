using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveWorld : MonoBehaviour
{
#if UNITY_EDITOR
    [Header("In editor")]
    [SerializeField] private bool _enableInEditor = false;
#endif
    [Header("In game")]
    [SerializeField] private bool _enableInGame = true;
    public float _curveStart = -15f;
    public float _curveRange = 20f;
    public float _curveHeight = -0.04f;

    public static CurveWorld instance { get; private set; }

    private void Start()
    {
        instance = this;
        Shader.SetGlobalFloat("_Curve_start", _curveStart);
        Shader.SetGlobalFloat("_Curve_range", _curveRange);
        Shader.SetGlobalFloat("_Curve_height", _enableInGame ? _curveHeight : 0);
    }

    public void Set()
    {
        Shader.SetGlobalFloat("_Curve_start", _curveStart);
        Shader.SetGlobalFloat("_Curve_range", _curveRange);
        Shader.SetGlobalFloat("_Curve_height", _enableInGame ? _curveHeight : 0);
    }

    public void Set(float _start, float _range, float _height, bool _save = true)
    {
        if (_save)
        {
            _curveStart = _start;
            _curveRange = _range;
            _curveHeight = _height;
        }
        Shader.SetGlobalFloat("_Curve_start", _start);
        Shader.SetGlobalFloat("_Curve_range", _range);
        Shader.SetGlobalFloat("_Curve_height", _enableInGame ? _height : 0);
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        Set(_curveStart, _curveRange, _enableInEditor ? _curveHeight : 0, false);
    }
#endif
}
