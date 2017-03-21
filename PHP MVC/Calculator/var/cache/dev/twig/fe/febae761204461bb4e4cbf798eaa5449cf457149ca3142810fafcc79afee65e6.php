<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_2928671cff679a9910f6483b9c33153cb445560fbb289401de191d17f1375a4c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_ab12906d3d983f7dd15c302fa3137c38966d61bc31f50e982658315f6da67710 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ab12906d3d983f7dd15c302fa3137c38966d61bc31f50e982658315f6da67710->enter($__internal_ab12906d3d983f7dd15c302fa3137c38966d61bc31f50e982658315f6da67710_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_ab12906d3d983f7dd15c302fa3137c38966d61bc31f50e982658315f6da67710->leave($__internal_ab12906d3d983f7dd15c302fa3137c38966d61bc31f50e982658315f6da67710_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_fc50bb90e05b91686e82efbd761558e778e3b0e4c17814f1292c8c16c60aacc6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fc50bb90e05b91686e82efbd761558e778e3b0e4c17814f1292c8c16c60aacc6->enter($__internal_fc50bb90e05b91686e82efbd761558e778e3b0e4c17814f1292c8c16c60aacc6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_fc50bb90e05b91686e82efbd761558e778e3b0e4c17814f1292c8c16c60aacc6->leave($__internal_fc50bb90e05b91686e82efbd761558e778e3b0e4c17814f1292c8c16c60aacc6_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_d98fb3cf07a5c256f3ecdcfeef90218f724355696f342b2fd94b462e6ab52ff0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d98fb3cf07a5c256f3ecdcfeef90218f724355696f342b2fd94b462e6ab52ff0->enter($__internal_d98fb3cf07a5c256f3ecdcfeef90218f724355696f342b2fd94b462e6ab52ff0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_d98fb3cf07a5c256f3ecdcfeef90218f724355696f342b2fd94b462e6ab52ff0->leave($__internal_d98fb3cf07a5c256f3ecdcfeef90218f724355696f342b2fd94b462e6ab52ff0_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_cbdde9e4719487bd5d1954ad5bf8251d5795735a2af0c96ceb30881bc8481952 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cbdde9e4719487bd5d1954ad5bf8251d5795735a2af0c96ceb30881bc8481952->enter($__internal_cbdde9e4719487bd5d1954ad5bf8251d5795735a2af0c96ceb30881bc8481952_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_cbdde9e4719487bd5d1954ad5bf8251d5795735a2af0c96ceb30881bc8481952->leave($__internal_cbdde9e4719487bd5d1954ad5bf8251d5795735a2af0c96ceb30881bc8481952_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}
