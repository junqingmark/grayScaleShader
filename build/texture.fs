#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture sampler
uniform sampler2D texture1;

void main()
{
	vec4 tex = texture(texture1, TexCoord);
    //Average
    //float c = (tex.r + tex.g + tex.b) / 3.0;
    //vec4 result = vec4(c, c, c, tex.a);

    //Lightness (desaturate)
    //float maxColor = max(tex.r, tex.g);
    //maxColor = max(maxColor, tex.b);
    //float minColor = min(tex.r, tex.g);
    //minColor = min(minColor, tex.b);
    //float r = (maxColor + minColor) * 0.5; 
    //vec4 result = vec4(r, r, r, tex.a);

    //Luminosity (BT709)
    float c = tex.r * 0.2126 + tex.g * 0.7152 + tex.b * 0.0722;
    vec4 result = vec4(c, c, c, tex.a);
    FragColor = result;
}