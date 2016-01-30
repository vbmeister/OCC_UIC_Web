@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html ng-app="demoapp">
<head>

    <script src="../scripts/angular.js"></script>
    <script src="../scripts/angular-resource.js"></script>
    <script src="../scripts/angular-route.js"></script>
    <script src="../scripts/angular-sanitize.js"></script>

    <script src="../scripts/angular-animate.js"></script>
    <script src="../scripts/angular-touch.js"></script>
    <script src="http://openlayers.org/en/v3.13.0/build/ol.js"></script>
    <link rel="stylesheet" href="http://openlayers.org/en/v3.13.0/css/ol.css" type="text/css">
    <script src="../scripts/ng-openlayers.js"></script>

    
    
    <script src="https://code.jquery.com/jquery-1.11.2.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    @*<script src="../bower_components/openlayers3/build/ol.js"></script>
        <script src="../bower_components/angular/angular.min.js"></script>
        <script src="../bower_components/angular-sanitize/angular-sanitize.min.js"></script>
        <script src="../dist/angular-openlayers-directive.js"></script>
        <link rel="stylesheet" href="../bower_components/openlayers3/build/ol.css" />*@
    <script>
        var app = angular.module("demoapp", ["openlayers-directive"]);
        app.controller("DemoController", ['$scope', function ($scope) {
            angular.extend($scope, {
                london: {
                    lat: 51.505,
                    lon: -0.09,
                    zoom: 8
                },
                defaults: {
                    layers: {
                        main: {
                            source: {
                                type: 'OSM',
                                url: 'http://{a-c}.tile.opencyclemap.org/cycle/{z}/{x}/{y}.png'
                            }
                        }
                    },
                    interactions: {
                        mouseWheelZoom: true
                    },
                    controls: {
                        zoom: false,
                        rotate: false,
                        attribution: false
                    }
                }
            });
        }]);
    </script>
</head>
<body ng-controller="DemoController">
    <openlayers ol-center="london" ol-defaults="defaults" width="100%" height="400px"></openlayers>
    <h1>Custom parameters example</h1>
    <p>These are the custom properties applied in this map:</p>
    <pre ng-bind="defaults | json"></pre>
</body>
</html>
