#pragma checksum "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "539851b42c9800361c5ce5295ce09bffdd450a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\_ViewImports.cshtml"
using CiclosDeVidaEjemplo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\_ViewImports.cshtml"
using CiclosDeVidaEjemplo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539851b42c9800361c5ce5295ce09bffdd450a0b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b629c855fdb4fd76e46cd4130f9447296e576a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    var transient = (MiObjeto)ViewBag.transient;
    var scoped = (MiObjeto)ViewBag.scoped;
    var singleton = (MiObjeto)ViewBag.singleton;

    var transient2 = (MiObjeto)ViewBag.transient2;
    var scoped2 = (MiObjeto)ViewBag.scoped2;
    var singleton2 = (MiObjeto)ViewBag.singleton2;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\" style=\"justify-content: center;\">\r\n    <div class=\"text-center\">\r\n        <h1>Transient 1: </h1>\r\n        <h3>");
#nullable restore
#line 17 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
       Write(transient.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h1>Scoped 1: </h1>\r\n        <h3>");
#nullable restore
#line 19 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
       Write(scoped.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h1>Singleton 1: </h1>\r\n        <h3>");
#nullable restore
#line 21 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
       Write(singleton.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n    <div class=\"text-center\">\r\n        <h1>Transient 2: </h1>\r\n        <h3>");
#nullable restore
#line 26 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
       Write(transient2.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h1>Scoped 2: </h1>\r\n        <h3>");
#nullable restore
#line 28 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
       Write(scoped2.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <h1>Singleton 2: </h1>\r\n        <h3>");
#nullable restore
#line 30 "C:\Projects\CiclosDeVidaEjemplo\CiclosDeVidaEjemplo\Views\Home\Index.cshtml"
       Write(singleton2.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    </div>
</div>
<br />
<br />
<p><strong> NOTA: </strong> Una de las mejores formas de entender el funcionamiento de cada tipo es abriendo otra pestaña y acceder la misma URL (crear un nuevo Request pero desde otra pestaña). 
    Notarás qué: <br />
    
    <ul>
        <li>Transient cambia de valor en ambos objetos tanto en la primera pestaña como en la segunda.</li>
        <li>Scoped mantiene el mismo valor en ambos objetos pero diferentes valores en cada Http Request</li>
        <li>Singleton simplemente no cambia, porque su instancia en ambos objetos y en todas las Http Request se mantienen.</li>
    </ul>
</p>
<hr />

<div class=""container-fluid"">
    <div class=""row"" style=""justify-content: center;"">
        <div class=""alert alert-primary col-3"" role=""alert"">
            <b>Transient:</b>
            <br />
            <ul>
                <li>Las dependencias son creadas cada vez que son solicitadas. Por ejemplo, en cada request de nuestra aplicación estas son creadas ");
            WriteLiteral(@"de nuevo. <strong>Es conveniente para liberar de la memoria cuando se dejen de usar.</strong></li>
                <br />
                <li>Se crean cada vez que se solicitan desde el contenedor de servicios. <strong>Esta vida útil funciona mejor para servicios ligeros y sin estado.</strong></li>
            </ul>

        </div>
        &nbsp;&nbsp;
        <div class=""alert alert-success col-3"" role=""alert"">
            <b>Scoped:</b>
            <br />
            <ul>
                <li>A diferencia del transient, mientras que estamos en el request y solicitamos una depencia esta será creada una sola vez hasta que el request muera.</li>
                <br />
                <li>Se crean una vez por solicitud del cliente (conexión).<strong> Se utiliza cuando queremos servir la misma instancia dentro del mismo contexto de una petición HTTP, pero diferente entre distintos contextos HTTP.</strong></li>
            </ul>
        </div>
        &nbsp;&nbsp;
        <div class=""alert alert-w");
            WriteLiteral(@"arning col-3"" role=""alert"">
            <b>Singleton:</b>
            <br />
            <ul>
                <li><strong>Se creará una sola depencia para todo el ciclo de vida de nuestro proyecto o hasta que el servidor sea reiniciado. Ideal para inicializar clases con parámetros.</strong></li>
                <br />
                <li>Se crean la primera vez que se solicitan o cuando Startup.ConfigureServices se ejecuta y se especifica una instancia con el registro del servicio. Cada solicitud posterior utiliza la misma instancia.</li>
            </ul>
        </div>
    </div>
    <hr />
    <h3 class=""text-center""> ¿Cuándo usar cada tipo de inyección? </h3>
    <hr />
    <div  style=""justify-content: center;"">
        <div class=""alert alert-primary col-12"" role=""alert"">
            <b>Transient:</b>
            <br />
            <br />
            <ul>
                <li>Utilizamos Transient cuando el servicio contiene estado que puede cambiar (es mutable)  y no es thread-safe. Ya");
            WriteLiteral(@" que cada servicio va a recibir su propia instancia, podemos consumir los métodos sin preocuparnos por si otros servicios están accediendo.</li>
                <br />
                <li>Por contra debemos gastar más memoria ya que necesitaremos más objetos y será algo más ineficiente.</li>
                <br />
                <li>Es muy común utilizar servicios transient cuando no tenemos claro qué opción utilizar.</li>
            </ul>

        </div>
        &nbsp;&nbsp;
        <div class=""alert alert-success col-12"" role=""alert"">
            <b>Scoped:</b>
            <br />
            <br />
            <p>
                Si creamos un servicio que está registrado como scoped este vivirá por el tiempo de vida que exista ese scope. En ASP.NET Core la aplicación crea un scope para cada request que recibe, normalmente desde el navegador.<br />
                Cada servicio scoped se creará una vez por request. Lo que quiere decir, que todos los servicios recibirán la misma instancia mi");
            WriteLiteral(@"entras dure el scope (la request) : <br />
                <pre>
                <code>
Request 1:
[
    ""Middleware: 0cff9660-1b62-4475-a1ae-976d9516abf9"",
    ""Controller: 0cff9660-1b62-4475-a1ae-976d9516abf9""
]
                                                                                                                                                                
Request 2:
[
    ""Middleware: 52dd3c3f-435e-4d72-99a3-00e227442ef4"",
    ""Controller: 52dd3c3f-435e-4d72-99a3-00e227442ef4""
]
                    </code>
                </pre>

                Un ejemplo muy común de creación de scoped es cuando tenemos un <b>""logId""</b> para poder hacer un mapa de todos los puntos por los que la llamada ha pasado.
            </p>
        </div>
        &nbsp;&nbsp;
        <div class=""alert alert-warning col-12"" role=""alert"">
            <b>Singleton:</b>
            <br />
            <br />
            <ul>
                <li>Cuando un servicio está registrado como singleton q");
            WriteLiteral(@"uiere decir que va  ser creado únicamente una única vez mientras la aplicación esté activa. La misma instancia será reutilizada e inyectada en todas las clases que la utilicen.</li>
                <br />
                <li>Si el servicio se utiliza muy frecuentemente puede proveer mejora en el rendimiento ya que se instancia una vez para la aplicación entera y no uno por servicio como hemos visto en Transient.</li>
                <br />
                <li>Finalmente utilizando singleton debemos tener cuidado ya que una única instancia puede suponer un gran montón de memoria, que nunca será liberada por el garbage collector, debemos tener esto muy en cuenta.</li>
            </ul><br />
            <pre>
            <code>
Request 1:
[
    ""Middleware: 01ae4b92-18ab-457a-be01-9a47ac231915"",
    ""Controller: 01ae4b92-18ab-457a-be01-9a47ac231915""
]
Request 2:
[
    ""Middleware: 01ae4b92-18ab-457a-be01-9a47ac231915"",
    ""Controller: 01ae4b92-18ab-457a-be01-9a47ac231915""
]

                ");
            WriteLiteral("</code>\r\n                </pre>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
