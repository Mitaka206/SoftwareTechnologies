<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_1435db9a4cf1d6968d4e8581cac81e48e551a6f85eb122e4dee240573f5c3cbe extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_9f03690c897576d9b3bae6c7ed8a3ee2e18a83f7e48c08158a68b6b173ee7d14 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9f03690c897576d9b3bae6c7ed8a3ee2e18a83f7e48c08158a68b6b173ee7d14->enter($__internal_9f03690c897576d9b3bae6c7ed8a3ee2e18a83f7e48c08158a68b6b173ee7d14_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_9f03690c897576d9b3bae6c7ed8a3ee2e18a83f7e48c08158a68b6b173ee7d14->leave($__internal_9f03690c897576d9b3bae6c7ed8a3ee2e18a83f7e48c08158a68b6b173ee7d14_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_59f5066c79447ed4534dafd70dcdef7e894116506dcdc0d6a0d3519fe720e24d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_59f5066c79447ed4534dafd70dcdef7e894116506dcdc0d6a0d3519fe720e24d->enter($__internal_59f5066c79447ed4534dafd70dcdef7e894116506dcdc0d6a0d3519fe720e24d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_59f5066c79447ed4534dafd70dcdef7e894116506dcdc0d6a0d3519fe720e24d->leave($__internal_59f5066c79447ed4534dafd70dcdef7e894116506dcdc0d6a0d3519fe720e24d_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_ae7e691015226f2b9615fdeb59f454758aaf0291b5e2df06aa3239a9a4c82eb0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ae7e691015226f2b9615fdeb59f454758aaf0291b5e2df06aa3239a9a4c82eb0->enter($__internal_ae7e691015226f2b9615fdeb59f454758aaf0291b5e2df06aa3239a9a4c82eb0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_ae7e691015226f2b9615fdeb59f454758aaf0291b5e2df06aa3239a9a4c82eb0->leave($__internal_ae7e691015226f2b9615fdeb59f454758aaf0291b5e2df06aa3239a9a4c82eb0_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_dc947f9c0195d220036860fd57859a02605ef26fc21848bfc994ba75979c26dd = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dc947f9c0195d220036860fd57859a02605ef26fc21848bfc994ba75979c26dd->enter($__internal_dc947f9c0195d220036860fd57859a02605ef26fc21848bfc994ba75979c26dd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_dc947f9c0195d220036860fd57859a02605ef26fc21848bfc994ba75979c26dd->leave($__internal_dc947f9c0195d220036860fd57859a02605ef26fc21848bfc994ba75979c26dd_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
