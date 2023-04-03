//Make sure its only included once!
#ifndef CURVE_SETTINGS_INCLUDED
#define CURVE_SETTINGS_INCLUDED
 
float _Curve_start;
float _Curve_range;
float _Curve_height;
 
void getCurveSettings_float(out float start, out float range, out float height)
{
    start = _Curve_start;
    range = _Curve_range;
    height = _Curve_height;
}

void getCurveSettings_half(out half start, out half range, out half height)
{
    start = _Curve_start;
    range = _Curve_range;
    height = _Curve_height;
}
#endif