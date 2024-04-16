window.initializeMap = function () {
    require([
        "esri/Map",
        "esri/views/MapView",
        "dojo/domReady!"
    ], function (Map, MapView) {
        var map = new Map({
            basemap: "topo-vector"
        });

        var view = new MapView({
            container: "map",
            map: map,
            center: [32.2903, 1.3733], // Center of Uganda
            zoom: 6 // Zoom level
        });
    });
};


//function initializeMap() {
//    require([
//        "esri/WebMap",
//        "esri/views/MapView",
//        "esri/widgets/Legend",
//        "esri/widgets/ScaleBar",
//        "esri/layers/GraphicsLayer",
//        "esri/widgets/Sketch",
//        "esri/widgets/CoordinateConversion"
//    ], function (WebMap, MapView, Legend, ScaleBar, GraphicsLayer, Sketch, CoordinateConversion) {

//        var webmap = new WebMap({
//            portalItem: {
//                //add your map id
//                id: "**Omitted**",
//                layers: [graphicsLayer]
//            }
//        });

//        var view = new MapView({
//            container: "viewDiv",
//            map: webmap,
//        });

//        var legend = new Legend({
//            view: view
//        });

//        view.ui.add(legend, "top-right");

//        var scalebar = new ScaleBar({
//            view: view
//        });

//        view.ui.add(scalebar, "bottom-left");

//        var graphicsLayer = new GraphicsLayer();
//        webmap.add(graphicsLayer);

//        var sketch = new Sketch({
//            view: view,
//            layer: graphicsLayer
//        });

//        view.ui.add(sketch, "top-right");

//        var coordsWidget = document.createElement("div");
//        coordsWidget.id = "coordsWidget";
//        coordsWidget.className = "esri-widget esri-component";
//        coordsWidget.style.padding = "7px 15px 5px";

//        view.ui.add(coordsWidget, "bottom-right");

//        function showCoordinates(pt) {
//            var coords = "Lat/Lon " + pt.latitude.toFixed(3) + " " + pt.longitude.toFixed(3) +
//                " | Scale 1:" + Math.round(view.scale * 1) / 1 +
//                " | Zoom " + view.zoom;
//            coordsWidget.innerHTML = coords;
//        }

//        view.watch("stationary", function (isStationary) {
//            showCoordinates(view.center);
//        });

//        view.on("pointer-move", function (evt) {
//            showCoordinates(view.toMap({ x: evt.x, y: evt.y }));
//        });

//        var coordinateConversionWidget = new CoordinateConversion({
//            view: view
//        });

//        view.ui.add(coordinateConversionWidget, "bottom-right");

//    });
//}