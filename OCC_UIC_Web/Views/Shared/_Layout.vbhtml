<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

    <title>Earthquakes in KML</title>
    <link rel="stylesheet" href="http://openlayers.org/en/v3.13.0/css/ol.css" type="text/css">
    <script src="http://openlayers.org/en/v3.13.0/build/ol.js"></script>
    <script src="https://code.jquery.com/jquery-1.11.2.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
    <style>
        #map {
            position: relative;
        }

        #info {
            position: absolute;
            height: 1px;
            width: 1px;
            z-index: 100;
        }

        .tooltip.in {
            opacity: 1;
            filter: alpha(opacity=100);
        }

        .tooltip.top .tooltip-arrow {
            border-top-color: white;
        }

        .tooltip-inner {
            border: 2px solid white;
        }
    </style>


</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Application name", "Index", "Home", Nothing, New With {Key .[class] = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("map", "map", "Home", Nothing, Nothing)</li>
                    <li>@Html.ActionLink("WellSeismic", "Index", "WellSeismic", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("Home", "Index", "Home", New With {.area = ""}, Nothing)</li>
                    <li>@Html.ActionLink("API", "Index", "Help", New With {.area = ""}, Nothing)</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
