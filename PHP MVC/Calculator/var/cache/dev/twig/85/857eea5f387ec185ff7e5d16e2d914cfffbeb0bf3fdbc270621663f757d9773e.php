<?php

/* base.html.twig */
class __TwigTemplate_ab63695794a2756bf221691eadd35cd2542f708241bbbe9146fb6c8a19ec4bfe extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_55866265bdaab32851ca3d7206bc482a80eeb128538a62e4f336d1c628e02138 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_55866265bdaab32851ca3d7206bc482a80eeb128538a62e4f336d1c628e02138->enter($__internal_55866265bdaab32851ca3d7206bc482a80eeb128538a62e4f336d1c628e02138_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_55866265bdaab32851ca3d7206bc482a80eeb128538a62e4f336d1c628e02138->leave($__internal_55866265bdaab32851ca3d7206bc482a80eeb128538a62e4f336d1c628e02138_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_14cba12211399c6150eff97f03e3a6112c1b8ce12f7b56ce157e69eae9e9be1c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_14cba12211399c6150eff97f03e3a6112c1b8ce12f7b56ce157e69eae9e9be1c->enter($__internal_14cba12211399c6150eff97f03e3a6112c1b8ce12f7b56ce157e69eae9e9be1c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_14cba12211399c6150eff97f03e3a6112c1b8ce12f7b56ce157e69eae9e9be1c->leave($__internal_14cba12211399c6150eff97f03e3a6112c1b8ce12f7b56ce157e69eae9e9be1c_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_ada6916582ac7b16c6bb96778f11450d62c08a0e0d8cf96aded11448531884c8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ada6916582ac7b16c6bb96778f11450d62c08a0e0d8cf96aded11448531884c8->enter($__internal_ada6916582ac7b16c6bb96778f11450d62c08a0e0d8cf96aded11448531884c8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_ada6916582ac7b16c6bb96778f11450d62c08a0e0d8cf96aded11448531884c8->leave($__internal_ada6916582ac7b16c6bb96778f11450d62c08a0e0d8cf96aded11448531884c8_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_877894c138d9ab577f78c43bdd82e76c6a6838f6e55530062bef0d735332b65a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_877894c138d9ab577f78c43bdd82e76c6a6838f6e55530062bef0d735332b65a->enter($__internal_877894c138d9ab577f78c43bdd82e76c6a6838f6e55530062bef0d735332b65a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_877894c138d9ab577f78c43bdd82e76c6a6838f6e55530062bef0d735332b65a->leave($__internal_877894c138d9ab577f78c43bdd82e76c6a6838f6e55530062bef0d735332b65a_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_9dda2015ac098c06ec45fc9af704358488e6e56f6725a26681bd461cbb10ffa7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9dda2015ac098c06ec45fc9af704358488e6e56f6725a26681bd461cbb10ffa7->enter($__internal_9dda2015ac098c06ec45fc9af704358488e6e56f6725a26681bd461cbb10ffa7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_9dda2015ac098c06ec45fc9af704358488e6e56f6725a26681bd461cbb10ffa7->leave($__internal_9dda2015ac098c06ec45fc9af704358488e6e56f6725a26681bd461cbb10ffa7_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_3266c684c79d04fdfcfb1048c4a994db0d65861da0829972a29ac1903d0ce13c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3266c684c79d04fdfcfb1048c4a994db0d65861da0829972a29ac1903d0ce13c->enter($__internal_3266c684c79d04fdfcfb1048c4a994db0d65861da0829972a29ac1903d0ce13c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_3266c684c79d04fdfcfb1048c4a994db0d65861da0829972a29ac1903d0ce13c->leave($__internal_3266c684c79d04fdfcfb1048c4a994db0d65861da0829972a29ac1903d0ce13c_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_7cb47b36c5d78af48d76f6e17f337d0c709cf6daf9d6acf0730e55d3a1f2c7b3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7cb47b36c5d78af48d76f6e17f337d0c709cf6daf9d6acf0730e55d3a1f2c7b3->enter($__internal_7cb47b36c5d78af48d76f6e17f337d0c709cf6daf9d6acf0730e55d3a1f2c7b3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_7cb47b36c5d78af48d76f6e17f337d0c709cf6daf9d6acf0730e55d3a1f2c7b3->leave($__internal_7cb47b36c5d78af48d76f6e17f337d0c709cf6daf9d6acf0730e55d3a1f2c7b3_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_5081bff1a01d9e2d4a670f79dafb68490f210cfe0a99af5ca4cec4950b7fd473 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5081bff1a01d9e2d4a670f79dafb68490f210cfe0a99af5ca4cec4950b7fd473->enter($__internal_5081bff1a01d9e2d4a670f79dafb68490f210cfe0a99af5ca4cec4950b7fd473_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_5081bff1a01d9e2d4a670f79dafb68490f210cfe0a99af5ca4cec4950b7fd473->leave($__internal_5081bff1a01d9e2d4a670f79dafb68490f210cfe0a99af5ca4cec4950b7fd473_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
